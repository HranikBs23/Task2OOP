using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2_OOP
{

    
    class Employee
    {
        //public properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        //private property

        private int Number { get; set; }
        //protected properties

        protected  decimal Salary { get; set; }

        //Internal property
        internal string EmpId { get; set; }

        //Public Method
        public void Sayhello () {

            Console.WriteLine($"Hello, My name is {FirstName} {LastName}, Age: {Age} and My ID is: {EmpId}. My contact Number is {Number}. Salary:{Salary}");

        }

      


        //Protected method 
        protected void Raise (decimal amount)
        {
            Salary += amount;
            Console.WriteLine($"Congrats! Salary increased and new salary is {Salary}");
        }

        //Internal method
        internal void PayRoll ()
        {
            Console.WriteLine($" processing payroll for employee {FirstName}  {LastName} {EmpId}");
        }
        //private Method
        private decimal  CalcBonus (decimal performance)
        {
            decimal bonus =0;
            if (performance >= 90)
            {
                bonus = Salary * 0.2m;
            }
            else if(performance >= 80)
            {
                bonus = Salary * 0.1m;
            }
            return bonus;
        }

        //Public method that uses the private method 

        public void Bonus(decimal performance)
        {
            decimal bonus = CalcBonus (performance);
            Salary += bonus;
            Console.WriteLine($"Congrats {FirstName}! You Got Bonus {bonus}");
        }

        // constructor

        //

       
        public Employee(string FirstName, string LastName, int Age, int Number, string EmpId, decimal Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Number = Number;
            this.Salary = Salary;
            this.EmpId = EmpId;
        }
        public Employee(string Firstname, string Lastname)

        {
            this.FirstName = Firstname;
            this.LastName = Lastname;

        }


    }

    // Declare a struct named Person
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
    }


}
