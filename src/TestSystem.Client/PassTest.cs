using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestSystem.Common;

namespace TestClient
{
    public partial class PassTest : Form
    {
        private TestExam test;
        private int positionQuestion=0;
        public int ResultTest = 0;
        private List<CurrentAnswer> answers;
        public PassTest(TestExam test )
        {
            InitializeComponent();
            answers = new List<CurrentAnswer>();
            this.test = test;
            ShowQuestion();
            PositionChanged();
        }
        /// <summary>
        /// виводить на екран питання та список відповідей
        /// </summary>
        void ShowQuestion()
        {
            checkedListBoxAnswers.Items.Clear();
            labelNumberQuestion.Text = "Питання " + positionQuestion+1;
            labelQuestion.Text = test.BodyTest.Questions[positionQuestion].Text;
            foreach (var answer in test.BodyTest.Questions[positionQuestion].Answers)
            {
                checkedListBoxAnswers.Items.Add(answer.Text);
            }
        }
        /// <summary>
        /// зберігає інфо про те чи дана відповідь вірна
        /// </summary>
        void SaveAnswer()
        {
            string selectedAnswer= (string) checkedListBoxAnswers.SelectedItem;
            bool isCorrect = test.BodyTest.Questions[positionQuestion].Answers.Where(x => string.Compare(x.Text, selectedAnswer) == 0).Select(x => x.Correct).FirstOrDefault();

            var CurrentAnswer = answers.Where(x => x.IndexQuestion == positionQuestion).FirstOrDefault();
            if (CurrentAnswer == null)
                answers.Add(new CurrentAnswer() { IndexQuestion = positionQuestion, IsCorrectAnswer = isCorrect });
            else
                CurrentAnswer.IsCorrectAnswer = isCorrect;
        }
        /// <summary>
        /// виводить інфо про те на якому питанні користувач знаходиться після кожного переключення між питаннями
        /// </summary>
        void PositionChanged()
        {
            if (test.BodyTest.Questions.Count == 0)
                positionQuestion = 0;
            int p = positionQuestion + 1;
            labelStatus.Text = p.ToString() + " із " + test.BodyTest.Questions.Count.ToString();
            ShowQuestion();
        }

        /// <summary>
        /// збереження выдповіді і перехід на минуле питання або на останнє в списку  
        /// </summary>

        private void pictureBoxPrev_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            if (positionQuestion > 0)
            {
                --positionQuestion;
                PositionChanged();
            }               
        }
        /// <summary>
        ///збереження выдповіді і перехід на наступне питання або перше в списку
        /// </summary>

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            if (positionQuestion < test.BodyTest.Questions.Count - 1)
            {
                ++positionQuestion;
                PositionChanged();
            }                      
        }
        /// <summary>
        /// розраховує баз за тест і зберігає інформацію про пройдений тест
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendTest_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            ResultTest = CalculateResultTest();
            this.Close();
        }
        /// <summary>
        /// розраховує кількість балів за пройдений тест
        /// </summary>
        /// <returns></returns>
        private int CalculateResultTest()
        {
            double weight = 100 / test.BodyTest.Questions.Count;
            double result = 0;
            foreach (var answer in answers)
            {
                if (answer.IsCorrectAnswer)
                    result += weight;
            }
            return (int)result;
        }      
    }
}
