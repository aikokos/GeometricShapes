// <copyright file="Square.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>
namespace GeometricShapes
{
    /// <summary>
    /// The class represents Square.
    /// </summary>
    public class Square : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square" /> class.
        /// </summary>
        /// <param name="side">side length of square</param>
        public Square(double side)
        {
            this.Side = side;
        }

        /// <summary>
        /// Gets or sets the side of square
        /// </summary>
        /// <returns>Returns the side of square.</returns>
        public double Side { get; set; }

        /// <summary>
        /// Method for calculating area
        /// </summary>
        /// <returns>Returns the calculated area.</returns>
        public override double CalculateArea()
        {
            return this.Side * this.Side;
        }

        /// <summary>
        /// Method for calculating perimeter
        /// </summary>
        /// <returns>Returns the calculated perimeter.</returns>
        public override double CalculatePerimeter()
        {
            return 4 * this.Side;
        }
    }
}
