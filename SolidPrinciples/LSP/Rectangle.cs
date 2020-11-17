namespace SolidPrinciples.LSP
{
    /// <summary>
    /// Class Rectangle
    /// </summary>
    class Rectangle : IShape
    {
        /// <summary>
        /// Gets or sets width
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets Height
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Calculates areas
        /// </summary>
        /// <returns>Returns area</returns>
        public double CalculateArea() => Width * Height;
    }
}
