﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TestSystem.Common;

namespace TestClient
{
    public partial class Tests : Form
    {
        /// <summary>
        /// зберігає токен для Requst
        /// </summary>
        private string token = String.Empty;
        /// <summary>
        /// зберігає всіх тестів які студент може здати і які уже здавав
        /// </summary>
        private List<TestExam> tests;
        public Tests(string token)
        {
            InitializeComponent();
            this.token = token;
        }
        private void Tests_Load(object sender, EventArgs e)
        {
            tests = new List<TestExam>();
            //SetTests();  //заглушка
            //отримати відповідь з сервера
            GetTests();
            ShowTests();
        }
        /// <summary>
        /// розділяє тести на доступні для здачі і на тести які уже здавались
        /// </summary>
        private void ShowTests()
        {
            panelAvailableTests.Controls.Clear();
            listView1.Items.Clear();
            if (tests.Count > 0)
            {
                foreach (var test in tests)
                {
                    if (test.IsAvailable)
                    {
                        Button button = new Button();
                        button.Text = test.BodyTest.Name;
                        button.Size = new Size(639, 25);
                        button.Dock = DockStyle.Top;
                        button.ForeColor = Color.White;
                        button.Click += buttonPassTest_Click;
                        panelAvailableTests.Controls.Add(button);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(test.BodyTest.Name);
                        item.ForeColor = Color.White;
                        item.SubItems.Add(test.BodyTest.Subject);
                        item.SubItems.Add(test.Result.ToString());
                        listView1.Items.Add(item);
                    }
                }
            }
        }
        private void SetTests()
        {
            List<Answer> answers = new List<Answer>();
            answers.Add(new Answer() { Text = "x+2" });
            answers.Add(new Answer() { Text = "x2" });
            answers.Add(new Answer() { Text = "b ^ 2 - 4ac", Correct = true });

            TestExam test1 = new TestExam();
            test1.BodyTest.Questions.Add(new Question(answers, "D="));
            test1.BodyTest.Questions.Add(new Question(answers, "x1="));
            test1.IsAvailable = true;
            test1.BodyTest.Name = "Test1";
            test1.BodyTest.Subject = "Math";
            tests.Add(test1);

            TestExam test2 = new TestExam();
            test2.BodyTest.Questions.Add(new Question(answers, "И"));
            test2.BodyTest.Questions.Add(new Question(answers, "аапвап"));
            test2.IsAvailable = true;
            test2.BodyTest.Name = "Test2";
            test2.BodyTest.Subject = "Math";
            tests.Add(test2);
            answers.Add(new Answer() { Text = "ghgh" });
            TestExam test3 = new TestExam();
            test2.BodyTest.Questions.Add(new Question(answers, "fgfg"));
            test2.BodyTest.Questions.Add(new Question(answers, "dfdп"));
            test3.IsAvailable = false;
            test3.BodyTest.Name = "Test3";
            test3.BodyTest.Subject = "Math";
            tests.Add(test3);
        }

        /// <summary>
        /// робить запит до сервера на отримання списку тестів
        /// </summary>
        private void GetTests()
        {
            RestClient client = new RestClient("http://localhost:32225");
            var request = new RestRequest("test/exam", Method.GET);
            request.AddHeader("Authentication", $"Bearer { token}");
            var response = client.Execute<List<TestExam>>(request);
            tests.AddRange(response.Data.ToList());
        }

        private void buttonPassTest_Click(object sender, EventArgs e)
        {
            Button testButton = sender as Button;
            TestExam t = tests.Where(x => string.Compare(x.BodyTest.Name, testButton.Text) == 0).FirstOrDefault();
            PassTest passTest = new PassTest(t);
            passTest.ShowDialog();
            int Grade = passTest.ResultTest;
            MessageBox.Show(Grade.ToString());
            TestResult testResult = new TestResult() {  IdTest = t.Id, Grade = Grade, Date = DateTime.Now };
            //відправити на сервер 
            SendTestResult(new TestExam
            {
                Id = t.Id,
                Result = Grade
            });

            //оновити вигляд тестів
            var passedTest = tests.Where(x => x.Id == t.Id).FirstOrDefault();
            passedTest.IsAvailable = false;
            passedTest.Result = Grade;
            passedTest.Date = testResult.Date;
            ShowTests();
        }
        /// <summary>
        /// відправляє результати пройденого тесту на сервер
        /// </summary>
        /// <param name="result"> результат пройденого тесту для відправки </param>
        private void SendTestResult(TestExam result)
        {
            var client = new RestClient("http://localhost:32225");
            var request = new RestRequest("test/exam", Method.POST);
            request.AddHeader("Authentication", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(result);
            client.Execute<TestResult>(request);
        }
        /// <summary>
        /// робить повторний запит на сервер і оновлює інформацію про тести
        /// </summary>       
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            tests.Clear();
            GetTests();
            ShowTests();
        }
    }
}
