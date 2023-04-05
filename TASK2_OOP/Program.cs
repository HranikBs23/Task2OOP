using System;
using System.Numerics;
using System.Text;
using static TASK2_OOP.Person;

namespace TASK2_OOP
{

  class Program
    {

        //Enum
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

            Console.WriteLine($"*******************  Brainstation 23 TASK 2     ****************************");


            Console.WriteLine("************************** types of properties and methods    ******************************");
          
            Employee emp1 = new Employee("ANIK","RAHMAN",25,88015211,"BS1364",10000);
            Employee emp2 = new Employee("Tonmoy","Saha",24,8801933,"BS1359",10000);

            emp1.Sayhello();
            emp2.Sayhello();

            emp1.Bonus(95);



            Console.WriteLine("************************** Inheritance   ******************************");
            
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

            


            ///// *************** Structure *****************************///

            // Create an instance of the Person struct
            Person person1 = new Person();
            person1.Name = "HABIBUR";
            person1.Age = 27;

            // Call the PrintDetails method to print the person's details
            person1.PrintDetails();


            /// *********************   Refrence   **************************  ///
            /// 
            MyClass obj1 = new MyClass();
            obj1.Value = 10;
            MyClass obj2 = obj1; // obj2 now references the same object as obj1
            obj2.Value = 20; // changes the value of the object referenced by obj1

            Console.WriteLine(obj1.Value); // outputs 20

            int num1 = 10;
            int num2 = num1; // a copy of the value is created
            num2 = 20; // changes the value of num2

            Console.WriteLine(num1); // outputs 10

            /// ********************* Constructor Overloading *************//
            /// 
            Cricketer cric1 = new Cricketer();
            Console.WriteLine("Name: " + cric1.Name + ", Age: " + cric1.Age + ", Team: " + cric1.Team);

            Cricketer cric2 = new Cricketer("ANIK");
            Console.WriteLine("Name: " + cric2.Name + ", Age: " + cric2.Age + ", Team: " + cric2.Team);

            Cricketer cric3 = new Cricketer("RONALDO", 25);
            Console.WriteLine("Name: " + cric3.Name + ", Age: " + cric3.Age + ", Team: " + cric3.Team);

            Cricketer cric4 = new Cricketer("MESSI", 30, "ARGENTINA");
            Console.WriteLine("Name: " + cric4.Name + ", Age: " + cric4.Age + ", Team: " + cric4.Team);




            ////*********** Method overloading ********* //////////////
            ///


            Calculator calc = new Calculator();

            int sum1 = calc.Add(1, 2);
            Console.WriteLine("Sum of 1 and 2 is: " + sum1);

            int sum2 = calc.Add(1, 2, 3);
            Console.WriteLine("Sum of 1, 2, and 3 is: " + sum2);

            double sum3 = calc.Add(1.5, 2.5);
            Console.WriteLine("Sum of 1.5 and 2.5 is: " + sum3);
            
            
            ////////***********      Arrays **********//////////

            ///// Declaring arrays of different types
            bool[] boolArray = new bool[15];
            char[] charArray = new char[15];
            int[] intArray = new int[15];
            long[] longArray = new long[15];
            double[] doubleArray = new double[15];
            string[] stringArray = new string[15];

            ///// Inserting dummy values to arrays
            for (int i = 0; i < 15; i++)
            {
                boolArray[i] = (i % 2 == 0); // alternate true and false
                charArray[i] = (char)(i + 65); // ASCII A, B, C, ...
                intArray[i] = i * 2;
                longArray[i] = (long)Math.Pow(10, i);
                doubleArray[i] = i * 1.5;
                stringArray[i] = "Element " + i;
            }
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
            foreach (bool x in boolArray)
            {
                if (Array.IndexOf(boolArray, x) == 5) continue; // Skip index 5

                if (Array.IndexOf(boolArray, x) > 10) break; // Stop at index 10

                Console.WriteLine($"boolArray[{Array.IndexOf(boolArray, x)}] = {x}");
            }

            //***********               ENUM                  ***********//

            // Convert string to enum
            string inputString = "Friday";
            DaysOfWeek DayFromString = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), inputString);
            Console.WriteLine($"Enum value from string: {DayFromString}");

            // Convert int to enum
            int inputInt = 3;
            DaysOfWeek DayFromInt = (DaysOfWeek)inputInt;
            Console.WriteLine($"Enum value from int: {DayFromInt}");

            // Convert enum to string
            DaysOfWeek DayOfWeek = DaysOfWeek.Wednesday;
            string DayOfWeekString = DayOfWeek.ToString();
            Console.WriteLine($"String value from enum: {DayOfWeekString}");

            // Convert enum to int
            int DayOfWeekInt = (int)DayOfWeek;
            Console.WriteLine($"Int value from enum: {DayOfWeekInt}");


            /***********       List       ****************///
            List<int> IntList = new List<int> { 1, 2, 3, 4, 5 };
            List<string> StringList = new List<string> { "Ronaldo", "Messi", "Neymar", "Benzama", "Ramos" };
            List<double> DoubleList = new List<double> { 1.23, 4.56, 7.89, 2.34, 5.67 };

            // Find out the number of elements in each list
            Console.WriteLine($"IntList Count: {IntList.Count}");
            Console.WriteLine($"StringList Count: {StringList.Count}");
            Console.WriteLine($"DoubleList Count: {DoubleList.Count}");

            // Add elements to a list
            IntList.Add(6);
            StringList.Add("Mbappe");
            DoubleList.Add(8.9);

            // Remove elements from a list
            IntList.Remove(3);
            StringList.Remove("Ramos");
            DoubleList.RemoveAt(2);

            // Sort a list
            IntList.Sort();
            StringList.Sort();
            DoubleList.Sort();

            // Reverse a list
            IntList.Reverse();
            StringList.Reverse();
            DoubleList.Reverse();

            // Insert an element at a specific index
            IntList.Insert(2, 7);
            StringList.Insert(4, "grape");
            DoubleList.Insert(1, 6.78);

            // Find the index of an element
            int index1 = IntList.IndexOf(5);
            int index2 = StringList.IndexOf("date");
            int index3 = DoubleList.IndexOf(4.56);
            Console.WriteLine($"Index of 5 in IntList: {index1}");
            Console.WriteLine($"Index of \"date\" in StringList: {index2}");
            Console.WriteLine($"Index of 4.56 in DoubleList: {index3}");

            // Check if an element is in a list
            bool contains1 = IntList.Contains(6);
            bool contains2 = StringList.Contains("Mbappe");
            bool contains3 = DoubleList.Contains(8.9);
            Console.WriteLine($"Does IntList contain 3?: {contains1}");
            Console.WriteLine($"Does StringList contain \"Mbappe\"?: {contains2}");
            Console.WriteLine($"Does DoubleList contain 8.9?: {contains3}");

            // Convert a list to an array
            int[] IntArray = IntList.ToArray();
            string[] StringArray = StringList.ToArray();
            double[] DoubleArray = DoubleList.ToArray();


            // *********** DATE TIME ********************//
            //for bd time culture info
            // Creating a DateTime object representing the current date and time
            DateTime now = DateTime.Now;

            // Print the date and time 
            Console.WriteLine("Current date and time: " + now);
            Console.WriteLine("Short date: " + now.ToShortDateString());
            Console.WriteLine("Long date: " + now.ToLongDateString());
            Console.WriteLine("Short time: " + now.ToShortTimeString());
            Console.WriteLine("Long time: " + now.ToLongTimeString());

            // Create a TimeSpan object 
            TimeSpan duration = new TimeSpan(3, 30, 0);

            // Add the duration to the current date and time to get a new DateTime object
            DateTime future = now.Add(duration);

            // Print the new date and time
            Console.WriteLine("Future date and time: " + future);

            // Subtract the current date and time from the future date and time to get a TimeSpan object
            TimeSpan difference = future - now;

            // Print the difference in hours, minutes, and seconds
            Console.WriteLine("Time difference: " + difference.Hours + " hours, " + difference.Minutes + " minutes, " + difference.Seconds + " seconds");


            //********** String **************//

            string text = "  Brainstation 23   ";

            // Trim whitespace
            string TrimmedText = text.Trim();
            Console.WriteLine(TrimmedText);

            // To upper case
            string UpperText = text.ToUpper();
            Console.WriteLine(UpperText);

            // To lower case
            string LowerText = text.ToLower();
            Console.WriteLine(LowerText);

            // Replace
            string ReplacedText = text.Replace("23", "3000");
            Console.WriteLine(ReplacedText);

            // Split
            string[] Words = text.Split(' ');
            Console.WriteLine(Words[0]);
            Console.WriteLine(Words[1]);
            Console.WriteLine(Words[2]);
            Console.WriteLine(Words[3]);

            // Substring
            string Substring = text.Substring(2, 5);
            Console.WriteLine(Substring);

            // Length
            int length = text.Length;
            Console.WriteLine(length); // Output: 16

            // Concatenate
            string _a = "BS";
            string _b = "13";
            string _c = "64";
            string ConcatenatedText = string.Concat(_a, " ", _b, _c);
            Console.WriteLine(ConcatenatedText);

            // Format
            int Goals = 832;
            string Player = "Ronaldo";
            string FormattedText = string.Format("Goat! He scored {0} and Remember the name {1}.", Goals, Player);
            Console.WriteLine(FormattedText);

            ///// ******************* StringBuilder ***********************/////

            StringBuilder sb = new StringBuilder("Brain Station");

            // Append a string to the StringBuilder
            sb.Append(" 232"); 

            // Insert a string at a specific position
            sb.Insert(5, ", ");

            // Remove characters from the StringBuilder
            sb.Remove(18, 1);

            // Replace a character in the StringBuilder
            sb.Replace("a", "A");

            // Convert the StringBuilder to a string
            string str = sb.ToString();

            Console.WriteLine(str);



            ////// ************************  Abstract ***********************///
            ///

            BS23 e1 = new Mohakhali();
            e1.Office();

            BS23 e2 = new Mirpur();
            e2.Office();



            /// **************** InterFace **********************////
            /// MusicPlayer player = new MusicPlayer();
            MusicPlayer player = new MusicPlayer();
            player.Play();
            player.Pause();
            player.Stop();



        }
    }
    

    }

