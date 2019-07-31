using System;
using System.Collections.Generic;

namespace UML
{
     class Program
    {
        public static List<Person> people = new List<Person> //outside in class, public static List<Person>
            {
                new Student("C#", 2019, 8000, "Anthony","The Moon"),
                new Student("Java", 2019, 8000, "bobby","Saturn"),
                new Student("FrontEnd", 2018, 9250, "Susan", "Plumber Land"),
                new Staff("GrandCircus", 15, "Tony", "By the butterfly wings"),
                new Staff("Grand Circus", 15,"Billy","Somewhere in Detroit")
            };
        static void Main(string[] args)
        {
            bool repeat = true;
            while(repeat)
            {
                Display();
                AddToList();
                Console.Clear();
                Display();
                Console.WriteLine("\nAdd new member? y/n\n");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    repeat = true;
                }
                else if (input == "n")
                {
                    Display();
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }

        public static void Display()
        {
            foreach (Person person in people) //person is object
            {
                Console.WriteLine($"{person}");
            }
        }
        public static void AddToList()
        { 
            Console.WriteLine("Staff or Student?");
            string response = Console.ReadLine().ToLower();
            if(response == "staff")
            {
                Console.WriteLine("Enter name?");
                string name = Console.ReadLine();

                Console.WriteLine("Address: ");
                string address = Console.ReadLine();


                Console.WriteLine("Enter school.");
                string school = Console.ReadLine();

                Console.WriteLine("Enter Pay: ");
                double pay = double.Parse(Console.ReadLine());

                Staff staff = new Staff(school, pay, name, address);
                people.Add(staff);
                //cause its private, passed 
                //through parameters
                //Display();
                
            }
            else if (response == "student")
            {
                int countTwo = 0;
                Console.WriteLine("Enter name?");
                string name = Console.ReadLine();

                Console.WriteLine("Address: ");
                string address = Console.ReadLine();

                Console.WriteLine("Enter school.");
                string school = Console.ReadLine();

                Console.WriteLine("Enter Year");
                string year = Console.ReadLine();
                int inputYear = int.Parse(year);

                Console.WriteLine("Enter fee. ");
                double fee = double.Parse(Console.ReadLine());

                Student student = new Student(school, inputYear, fee, name, address);
                people.Add(student);
                countTwo++;
                Display();
            }
        }
     }
}

//Staff staff = new Staff(); //allowed because OF DEFAULT CONSTRUCTOR
//staff.School = "Grand Circus"; //staff becomes OBJECT, School is coming from PROPERTIES OF that CLASS
//staff.Pay = 24;
//Student student = new Student("c#",2000,55,"Danny","21210");

//cant access properties cause they're private, have to pass through the parameter.
// staff.Name doesnt work cause it's private in Person abstract class
//staff.Address if it's public in Persons abstract class

//people.Add(staff);
//DateTime datetime = DateTime.Now.Date;
// Console.WriteLine(datetime.ToString("MM/dd/yyyy"));//by making it ToString, allows you to format
//date in anyway you want