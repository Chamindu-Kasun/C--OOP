class Student : Person{
    public string Grade { get; set; }

    public override void SayHello()
    {
        Console.WriteLine("Hello, my name is " + GetName() + " and I am a student.");
    }

    public void ShowGrade(){
        Console.WriteLine("My grade is " + Grade);
    }
}