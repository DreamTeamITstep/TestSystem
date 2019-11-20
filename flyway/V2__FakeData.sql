insert into Role(Name)VALUES ('Admin')
go
insert into Role(Name)VALUES ('Teacher')
go
insert into Role(Name)VALUES ('Student')
go
insert into Admin(FullName, Id_Role, Password) values ('Admin pro',1,'admin')
go
insert into Admin(FullName, Id_Role, Password) values ('Admin noob',1,'admin')
go
insert into Teacher(FullName, Id_Role, Password) values ('Teacher one',2,'login')
go
insert into Teacher(FullName, Id_Role, Password) values ('Teacher two',2,'login')
go
insert into Subject(Name)values ('programming')
go
insert into Subject(Name)values ('Informatics')
go
insert into [Group](Name)VALUES('s30r-1')
go
insert into [Group](Name)VALUES('s30rp-2')
go
insert into Student(FullName, Id_Role, Id_Group, Password) VALUES ('Kayumov Alexander',3,1,'alex')
go
insert into Student(FullName, Id_Role, Id_Group, Password) VALUES ('Ivanyuk Zoryana',3,1,'zoryana')
go
insert into Student(FullName, Id_Role, Id_Group, Password) VALUES ('Kuharchuk Vladimir',3,1,'vova')
go
insert into Student(FullName, Id_Role, Id_Group, Password) VALUES ('Someone else one',3,2,'one')
go
insert into Student(FullName, Id_Role, Id_Group, Password) VALUES ('Someone else two',3,2,'two')
go
insert into Test(Name, Id_Teacher, Id_Subject, Date, Content) values ('Test Runner',1,1,'2019-11-20','BodyTest')
go
insert into Test(Name, Id_Teacher, Id_Subject, Date, Content) values ('Super Admin',2,2,'2019-11-20','BodyTest')
go
insert into GroupStudent(Id_Group, Id_Student) values (1,1)
go
insert into GroupStudent(Id_Group, Id_Student) values (1,2)
go
insert into GroupStudent(Id_Group, Id_Student) values (1,3)
go
insert into GroupStudent(Id_Group, Id_Student) values (2,4)
go
insert into GroupStudent(Id_Group, Id_Student) values (2,5)
go
insert into GroupTest(Id_Teacher, Id_Test, Id_Group, Date) values (1,1,1,'2019-11-21')
go
insert into GroupTest(Id_Teacher, Id_Test, Id_Group, Date) values (2,2,2,'2019-11-21')