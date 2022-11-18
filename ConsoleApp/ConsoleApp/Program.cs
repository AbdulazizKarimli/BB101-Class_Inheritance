#region Anonymous object, Class
//var stu1 = new
//{
//    name = "Urfan",
//    surname = "Pehlevanov",
//    age = 20
//};

//var stu2 = new
//{
//    name = "Ayat",
//    surname = "Nezirli",
//    age = 20
//};

//Console.WriteLine(stu1.name+" "+stu1.surname);
//Console.WriteLine(stu2.name+" "+stu2.surname);

//instance
Student stu1 = new Student("Test","Testov",20);
Person mother = new Person("Teste","Testova",40);
stu1.mother = mother;

Console.WriteLine(stu1.mother.Info());
//Engineer engineer = new Engineer(); 
//stu1.surname = "Pehlevanov";
//stu1.age = 20;


//Student stu2 = new Student();
//stu2.surname = "Nezirli";
//stu2.age = 20;

//Console.WriteLine(stu1.Info());
//Console.WriteLine(stu2.Info());
#endregion
