
internal class Person
{
    public string name;
    public string surname;
    public int age;
    public Person mother;
    public Person()
    {
        Console.WriteLine("Person is created");
    }
    public Person(string name)
    {

    }
    public Person(string name,string surname,int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    public string Info()
    {
        return $"{name} {surname} {age}";
    }

}
