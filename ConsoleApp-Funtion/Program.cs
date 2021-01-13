using System;

namespace ConsoleApp_Funtion
{
    class Program
    {

        //Funtion without parameters
        public void Show()
        {
            Console.WriteLine("This is non parameterized funtion");
        }

        // Funtion with parameters
        public void Show2(string message)
        {
            Console.WriteLine("Hello " + message);
        }

        //Funcion return type and params
        public string Show3(string message)
        {
            Console.WriteLine("Inside Show3 Funtion");
            return message;
        }
        static void Main(string[] args)
        {
            Program program = new Program(); //Creating Object
            program.Show(); // Calling funtion
            program.Show2("My Name is Denis and i am programer");

            string messages = program.Show3("Desde la funcion 3");
            Console.WriteLine("Hello " + messages);
        }
    }
}
