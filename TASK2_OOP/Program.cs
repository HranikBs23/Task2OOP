using System;

namespace TASK2_OOP
{

  class Program
    {

        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args) {


            //Class and Obejct , Method Question 1
            Employee emp1 = new Employee("ANIK","RAHMAN",25,88015211,"BS1364",10000);
            Employee emp2 = new Employee("Tonmoy","Saha",24,8801933,"BS1359",10000);



            emp1.Sayhello();
            emp2.Sayhello();


            //set private properties

            //set  internal property

            //call public 

            //call private 

            //call internal method 

            //call public method that uses private
            emp1.Bonus(95);

            // Create instances of each class
            Vehicle v1 = new Vehicle("Toyota", "Camry", 2022);
            Car c1 = new Car("Ford", "Mustang", 2022, "OilCooled");
            Sedan s1 = new Sedan("Mercedes", "S Class", 2022, "Fi", true);
            Truck t1 = new Truck("Ford", "F-150", 2022,"Yellow");

            // Call the Start method for each instance
            v1.Start(); // Vehicle starting
            c1.Start(); // Car starting
            s1.Start(); // Sedan starting
            t1.Start(); // Truck starting

            // Example of upcasting
            Car car = new Car("Toyota", "Camry", 2020, "V6");
            Vehicle vehicle = car; // Upcasting Car to Vehicle

            Console.WriteLine($"Vehicle: {vehicle.Make} {vehicle.Model} {vehicle.Year}");
            vehicle.Start(); // Calls Car's overridden Start() method

            // Example of downcasting
            Vehicle vehicle2 = new Sedan("Mercedes-Benz", "S-Class", 2022, "V8", true);
            Sedan sedan = (Sedan)vehicle2; // Downcasting Vehicle to Sedan

            Console.WriteLine($"Sedan: {sedan.Make} {sedan.Model} {sedan.Year} {sedan.Engine} {sedan.IsLuxury}");
            sedan.Start(); // Calls Sedan's overridden Start() method

            //abstract
            Rectangle rect = new Rectangle(5, 10);

            Console.WriteLine("Rectangle area: " + rect.Area());


            // Create an instance of the Person struct
            Person person1 = new Person();
            person1.Name = "John";
            person1.Age = 30;

            // Call the PrintDetails method to print the person's details
            person1.PrintDetails();


            /// Refrence 
            /// 
            int a = 10;
            int b = a;
            Console.WriteLine($"a = {a}, b = {b}");  // Output: a = 10, b = 10

            RefPrim obj1 = new RefPrim();
            obj1.x = 10;
            RefPrim obj2 = obj1;
            obj2.x = 20;
            Console.WriteLine($"obj1.x = {obj1.x}, obj2.x = {obj2.x}");  // Output: obj1.x = 20, obj2.x = 20

            ///// Declare arrays of different types
            bool[] boolArray = new bool[15];
            char[] charArray = new char[15];
            int[] intArray = new int[15];
            long[] longArray = new long[15];
            double[] doubleArray = new double[15];
            string[] stringArray = new string[15];

            // Insert dummy values to arrays
            for (int i = 0; i < 15; i++)
            {
                boolArray[i] = (i % 2 == 0); // alternate true and false
                charArray[i] = (char)(i + 65); // ASCII A, B, C, ...
                intArray[i] = i * 2;
                longArray[i] = (long)Math.Pow(10, i);
                doubleArray[i] = i * 1.5;
                stringArray[i] = "Element " + i;
            }

            //For loop
            // Using for loop
            for (int i = 0; i < 15; i++)
            {
                if (i == 5) continue; // Skip index 5

                if (i > 10) break; // Stop at index 10

                Console.WriteLine($"boolArray[{i}] = {boolArray[i]}");
                Console.WriteLine($"charArray[{i}] = {charArray[i]}");
                Console.WriteLine($"intArray[{i}] = {intArray[i]}");
                Console.WriteLine($"longArray[{i}] = {longArray[i]}");
                Console.WriteLine($"doubleArray[{i}] = {doubleArray[i]}");
                Console.WriteLine($"stringArray[{i}] = {stringArray[i]}");
            }

            // Using foreach loop
            foreach (bool b in boolArray)
            {
                if (Array.IndexOf(boolArray, b) == 5) continue; // Skip index 5

                if (Array.IndexOf(boolArray, b) > 10) break; // Stop at index 10

                Console.WriteLine($"boolArray[{Array.IndexOf(boolArray, b)}] = {b}");
            }

            foreach (char c in charArray)
            {
                if (Array.IndexOf(charArray, c) == 5) continue; // Skip index 5

                if (Array.IndexOf(charArray, c) > 10) break; // Stop at index 10

                Console.WriteLine($"charArray[{Array.IndexOf(charArray, c)}] = {c}");
            }

            ///ENum
            ///
        

        // Convert string to enum
        string inputString = "Friday";
        DaysOfWeek dayFromString = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), inputString);
        Console.WriteLine($"Enum value from string: {dayFromString}");

        // Convert int to enum
        int inputInt = 3;
        DaysOfWeek dayFromInt = (DaysOfWeek)inputInt;
        Console.WriteLine($"Enum value from int: {dayFromInt}");

         // Convert enum to string
         DaysOfWeek dayOfWeek = DaysOfWeek.Wednesday;
        string dayOfWeekString = dayOfWeek.ToString();
        Console.WriteLine($"String value from enum: {dayOfWeekString}");

          // Convert enum to int
         int dayOfWeekInt = (int)dayOfWeek;
        Console.WriteLine($"Int value from enum: {dayOfWeekInt}");

        }
}
    

    }

