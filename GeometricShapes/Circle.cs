// <copyright file="Circle.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>
namespace GeometricShapes
{
    /// <summary>
    /// The class represents Circle.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        /// <param name="radius">radius of circle</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets radius
        /// </summary>
        /// <returns>Returns radius.</returns>
        public double Radius { get; set; }

        /// <summary>
        /// Method for calculating area
        /// </summary>
        /// <returns>Returns the calculated area.</returns>
        public override double CalculateArea()
        {
            return Shape.PI * this.Radius * this.Radius;
        }

        /// <summary>
        /// Method for calculating perimeter
        /// </summary>
        /// <returns>Returns the calculated perimeter.</returns>
        public override double CalculatePerimeter()
        {
            return 2 * Shape.PI * this.Radius;
        }
    }
}
