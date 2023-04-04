using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2_OOP
{

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
        public Sedan(string Make, string Model, int Year, string Engine, bool IsLuxury) : base(Make, Model, Year,Engine)
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
        public Truck(string Make, string Model, int Year, string Color) : base(Make, Model,Year)
        {
            this.Color = Color;
        }

        public override void Start()
        {
            Console.WriteLine("Truck starting");
        }
    }

    // Interface
    public interface IShape
    {
        double Area();
    }

    // Abstract class
    public abstract class Shape
    {
        protected double width;
        protected double height;

        public Shape(double w, double h)
        {
            width = w;
            height = h;
        }

        public abstract double Area();
    }

    // Class implementing interface and extending abstract class
    public class Rectangle : Shape, IShape
    {
        public Rectangle(double w, double h) : base(w, h) { }

        public override double Area()
        {
            return width * height;
        }
    }

    //Ref Prim
    public class RefPrim
    {
        public int x;
    }
}
