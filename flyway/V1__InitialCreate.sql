create table Role
(
    Id   int identity
        primary key,
    Name varchar(50)
)
go

create table Admin
(
    Id       int identity
        primary key,
    FullName varchar(100),
    Id_Role  int
        constraint Admin_Role__fk
            references Role,
    Password varchar(50)
)
go

create table Teacher
(
    Id       int identity
        primary key,
    FullName varchar(100),
    Id_Role  int
        constraint Teacher_Role__fk
            references Role,
    Password varchar(50)
)
go

create table Subject
(
    Id   int identity
        primary key,
    Name varchar(50)
)
go

create table [Group]
(
    Id   int identity
        primary key,
    Name varchar(50),
    Path varchar(250)
)
go

create table Student
(
    Id       int identity
        primary key,
    FullName varchar(100),
    Id_Role  int
        constraint Student_Role__fk
            references Role,
    Id_Group int
        constraint Student_Group__fk
            references [Group],
    Password varchar(50)
)
go

create table GroupStudent
(
    Id_Group   int
        constraint GroupStudent_Group__fk
            references [Group],
    Id_Student int
        constraint GroupStudent_Student__fk
            references Student
)
go

create table Test
(
  Id         int identity
    primary key,
  Name       varchar(50),
  Id_Teacher int
    constraint Test_Teacher__fk
    references Teacher,
  Id_Subject int
    constraint Test_Subject__fk
    references Subject,
  Date       date,
  Content    varchar(max),
  TestResult int
)
go

create table GroupTest
(
    Id         int identity
        primary key,
    Id_Teacher int
        constraint GroupTest_Teacher__fk
            references Teacher,
    Id_Test    int
        constraint GroupTest_Test__fk
            references Test,
    Id_Group   int
        constraint GroupTest_Group__fk
            references [Group],
    Date       date
)
go

create table TestResult
(
    Id           int identity
        primary key,
    Date         date,
    Retaking     bit,
    Id_Student   int
        constraint TestResult_Student__fk
            references Student,
    Id_GroupTest int
        constraint TestResult_GroupTest__fk
            references GroupTest
)
go