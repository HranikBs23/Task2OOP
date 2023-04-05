using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2_OOP
{

 
    /// <summary>
    ///  **************   ALL THE CLASSES **********************////
    /// </summary>
    /// 



    ///  ***********  types of properties and methods ****************** //
    class Employee
    {
        //public properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        //private property

        private int Number { get; set; }
        //protected properties

        protected decimal Salary { get; set; }

        //Internal property
        internal string EmpId { get; set; }

        //Public Method
        public void Sayhello()
        {

            Console.WriteLine($"Hello, My name is {FirstName} {LastName}, Age: {Age} and My ID is: {EmpId}. My contact Number is {Number}. Salary:{Salary}");

        }




        //Protected method 
        protected void Raise(decimal amount)
        {
            Salary += amount;
            Console.WriteLine($"Congrats! Salary increased and new salary is {Salary}");
        }

        //Internal method
        internal void PayRoll()
        {
            Console.WriteLine($" processing payroll for employee {FirstName}  {LastName} {EmpId}");
        }

        //Private Method
        private decimal CalcBonus(decimal performance)
        {
            decimal bonus = 0;
            if (performance >= 90)
            {
                bonus = Salary * 0.2m;
            }
            else if (performance >= 80)
            {
                bonus = Salary * 0.1m;
            }
            return bonus;
        }

        //Public method that uses the Private method 

        public void Bonus(decimal performance)
        {
            decimal bonus = CalcBonus(performance);
            Salary += bonus;
            Console.WriteLine($"Congrats {FirstName}! You Got Bonus {bonus}");
        }

        // constructor




        public Employee(string FirstName, string LastName, int Age, int Number, string EmpId, decimal Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Number = Number;
            this.Salary = Salary;
            this.EmpId = EmpId;
        }



    }

    
    // *************   Declare a struct named Person *********************//
    public struct Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Method to print the person's details
        public void PrintDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }

        //// Constructor Overloading 


        public class Cricketer
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Team { get; set; }

            //No parameter
            public Cricketer()
            {
                Name = "Unknown";
                Age = 0;
                Team = "Unknown";
            }

            //single parameter
            public Cricketer(string name)
            {
                Name = name;
                Age = 0;
                Team = "Unknown";
            }

            //two parameter
            public Cricketer(string name, int age)
            {
                Name = name;
                Age = age;
                Team = "Unknown";
            }

            //all
            public Cricketer(string name, int age, string team)
            {
                Name = name;
                Age = age;
                Team = team;
            }
        }



        //********** CLasses are reference types ******** ////
        public class MyClass
        {
            public int Value;
        }

        ///// Method Overloading 
        ///


        public class Calculator
            {
                public int Add(int a, int b)
                {
                    return a + b;
                }

                public int Add(int a, int b, int c)
                {
                    return a + b + c;
                }

                public double Add(double a, double b)
                {
                    return a + b;
                }
            }


        }



    // ********************* Inheritance ******************************//

    // Base class
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructor
        public Vehicle(string Make, string Model, int Year)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
        }

        public virtual void Start()
        {
            Console.WriteLine("Vehicle starting");
        }
    }

    // Derived class using single inheritance
    public class Car : Vehicle
    {
        public string Engine { get; set; }

        // Constructor Inheritance
        public Car(string Make, string Model, int Year, string Engine) : base(Make, Model, Year)
        {
            this.Engine = Engine;
        }

        public override void Start()
        {
            Console.WriteLine("Car starting");
        }
    }

    // Derived class using multilevel inheritance
    public class Sedan : Car
    {
        public bool IsLuxury { get; set; }

        // Constructor
        public Sedan(string Make, string Model, int Year, string Engine, bool IsLuxury) : base(Make, Model, Year, Engine)
        {
            this.IsLuxury = IsLuxury;
        }

        public override void Start()
        {
            Console.WriteLine("Sedan starting");
        }
    }

    // Derived class using hierarchical inheritance
    public class Truck : Vehicle
    {
        public string Color { get; set; }

        // Constructor
        public Truck(string Make, string Model, int Year, string Color) : base(Make, Model, Year)
        {
            this.Color = Color;
        }

        public override void Start()
        {
            Console.WriteLine("Truck starting");
        }
    }


    ///// ***************** Multiple Inheritance ********************* ////
    ///
    // First interface
    public interface IAcademicInfo
    {
        int? StudentId { get; set; }
        string? Department { get; set; }
        double? GradePointAverage { get; set; }
    }

    // Second interface
    public interface IPersonalInfo
    {
        string? Name { get; set; }
        string? Address { get; set; }
        string? PhoneNumber { get; set; }
    }

    // Class implementing multiple interfaces
    public class Student : IAcademicInfo, IPersonalInfo
    {
        public int? StudentId { get; set; }
        public string? Department { get; set; }
        public double? GradePointAverage { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }




    ////// ****************************** Abstract ****************************/////
    ///

    public abstract class BS23
    {
        public abstract void Office();
    }

    public class Mohakhali : BS23
    {
        public override void Office()
        {
            Console.WriteLine("You are in Mohakhali...");
        }
    }

    public class Mirpur : BS23
    {
        public override void Office()
        {
            Console.WriteLine("You are in Mirpur...");
        }
    }
    //**************************    Interface ************************* ///////

    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    public class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing music...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping music...");
        }
    }

}





