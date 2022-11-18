
#region Anonymous object, Class
class Student:Person //class
{

    //Constructor - method, not exist return type,
    //can't call(only instance), name must be same with class!!!
    public Student():this("Abdulaziz","Kerimli",21)
    {
        Console.WriteLine("Student created");
    }
    public Student(string name):base(name)
    {
        this.name = name;
    }

    public Student(string name,string surname):this(name)
    {
        this.surname = surname;
    }

    public Student(string name, string surname, int age):this(name,surname)
    {
        this.age = age;
    }
}
#endregion

