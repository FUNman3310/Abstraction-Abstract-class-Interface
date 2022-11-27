using Account;

User user = new User("Mailrum","1765uafeETWFf", "Anton Ivanov");

user.ShowInfo();


Student student1 = new Student("Anton Ivanov", 76.4);
Student student2 = new Student("Semen Cavansirov", 80.1);
Student student3 = new Student("Gregor Antonov", 17.9);

student1.ShowStudentInfo();
student2.ShowStudentInfo();
student3.ShowStudentInfo();

Group group = new Group(6, "AA123");

group.AddStudent(student1);
group.AddStudent(student2);
group.AddStudent(student3);

Student student4 = group.GetStudent(2);

Student[] Arr = group.GetAllStudents();
