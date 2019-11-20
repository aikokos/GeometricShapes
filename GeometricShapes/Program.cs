// <copyright file="Program.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>
namespace GeometricShapes
{
    using System;

    /// <summary>
    /// The class is program to run.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method for running program
        /// </summary>
        /// <param name="args">arguments to console application</param>
        public static void Main(string[] args)
        {
            Circle c = new Circle(3);
            Console.WriteLine("The area of circle is " + c.CalculateArea());
            Console.WriteLine("The perimeter of circle is " + c.CalculatePerimeter());
            Triangle t = new Triangle(3, 6, 3, 4, 5);
            Console.WriteLine("The area of triangle is " + t.CalculateArea());
            Console.WriteLine("The perimeter of triangle is " + t.CalculatePerimeter());
            Square s = new Square(3);
            Console.WriteLine("The area of square is " + s.CalculateArea());
            Console.WriteLine("The perimeter of square is " + s.CalculatePerimeter());
            Rectangle r = new Rectangle(3, 5);
            Console.WriteLine("The area of rectangle is " + r.CalculateArea());
            Console.WriteLine("The perimeter of square is " + r.CalculatePerimeter());
        }
    }
}
