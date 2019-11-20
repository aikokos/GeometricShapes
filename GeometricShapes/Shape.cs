// <copyright file="Shape.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>
namespace GeometricShapes
{
    /// <summary>
    /// The class is base class Shape.
    /// </summary>
    public class Shape
    {
        /// <summary>
        /// Constant PI for calculations
        /// </summary>
        public const double PI = 3.1415;

        /// <summary>
        /// Method for calculating area
        /// </summary>
        /// <returns>Returns the calculated area.</returns>
        public virtual double CalculateArea() 
        {
            return 0;
        }

        /// <summary>
        /// Method for calculating perimeter
        /// </summary>
        /// <returns>Returns the calculated perimeter.</returns>
        public virtual double CalculatePerimeter()
        {
            return 0;
        }
    }
}
