// <copyright file="Triangle.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>
namespace GeometricShapes
{
    /// <summary>
    /// The class represents Triangle.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        /// <param name="bases">length of triangle's base</param>
        /// <param name="height">length of triangle's height</param>
        /// <param name="sideA">length of triangle's sideA</param>
        /// <param name="sideB">length of triangle's sideB</param>
        /// <param name="sideC">length of triangle's sideC</param>
        public Triangle(double bases, double height, double sideA, double sideB, double sideC)
        {
            this.Base = bases;
            this.Height = height;
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        /// <summary>
        /// Gets or sets the base of triangle
        /// </summary>
        /// <returns>Returns the base of triangle.</returns>
        public double Base { get; set; }

        /// <summary>
        /// Gets or sets the height of triangle
        /// </summary>
        /// <returns>Returns the height of triangle.</returns>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the first side of triangle
        /// </summary>
        /// <returns>Returns the first side of triangle.</returns>
        public double SideA { get; set; }

        /// <summary>
        /// Gets or sets the second side of triangle
        /// </summary>
        /// <returns>Returns the second side of triangle.</returns>
        public double SideB { get; set; }

        /// <summary>
        /// Gets or sets the third side of triangle
        /// </summary>
        /// <returns>Returns the third side of triangle.</returns>
        public double SideC { get; set; }

        /// <summary>
        /// Method for calculating area
        /// </summary>
        /// <returns>Returns the calculated area.</returns>
        public override double CalculateArea()
        {
            return  0.5 * this.Base * this.Height;
        }

        /// <summary>
        /// Method for calculating perimeter
        /// </summary>
        /// <returns>Returns the calculated perimeter.</returns>
        public override double CalculatePerimeter()
        {
            return this.SideA + this.SideB + this.SideC;
        }
    }
}
