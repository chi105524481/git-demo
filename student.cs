class student : Person
{

    public string school;
    public student(string name, int age, string school)
    {
        this.name = name;
        this.age = age;
        this.school = school;
    }
    public void PrintSchool()
    {
        Console.WriteLine(this.school);
    }













}