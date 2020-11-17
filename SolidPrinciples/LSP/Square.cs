namespace SolidPrinciples.LSP
{
    /// <summary>
    /// Class square
    /// </summary>
    class Square : IShape
    {
        /// <summary>
        /// Gets or sets side length
        /// </summary>
        public int SideLength { get; set; }

        /// <summary>
        /// Calculates area of square
        /// </summary>
        /// <returns>returns area</returns>
        public double CalculateArea() => SideLength * SideLength;
    }
}
