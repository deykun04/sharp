namespace ConsoleApp1
{    class Program
    {
        class Student
        {
            public int number = 14;
            public int GetProperties()
            {
                return number;
            }
        };
    static void Main(string[] args)
    {
        Console.Write("Please,enter your name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Your name is: "+ name);
        Student student = new Student();
        int number = student.GetProperties();
        Console.Write(number); 
        

    }
    }
}

