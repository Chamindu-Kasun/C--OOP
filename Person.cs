class Person{

    private string name;

    public void SetName(string name){
        this.name = name;
    }

    public string GetName(){
        return name;
    }

    public virtual void SayHello(){
        Console.WriteLine("Hello, my name is " + name);
    }
}