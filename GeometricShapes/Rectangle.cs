// <copyright file="Rectangle.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>
namespace GeometricShapes
{
    /// <summary>
    /// The class represents Rectangle.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle" /> class.
        /// </summary>
        /// <param name="sideA">first side of rectangle</param>
        /// <param name="sideB">second side of rectangle</param>
        public Rectangle(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }

        /// <summary>
        /// Gets or sets the first side
        /// </summary>
        /// <returns>Returns the first side.</returns>
        public double SideA { get; set; }

        /// <summary>
        /// Gets or sets the second side
        /// </summary>
        /// <returns>Returns the second side.</returns>
        public double SideB { get; set; }

        /// <summary>
        /// Method for calculating area
        /// </summary>
        /// <returns>Returns the calculated area.</returns>
        public override double CalculateArea()
        {
            return this.SideA * this.SideB;
        }

        /// <summary>
        /// Method for calculating perimeter
        /// </summary>
        /// <returns>Returns the calculated perimeter.</returns>
        public override double CalculatePerimeter()
        {
            return 2 * (this.SideA + this.SideB);
        }
    }
}
