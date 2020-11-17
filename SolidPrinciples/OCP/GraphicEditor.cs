namespace SolidPrinciples.OCP
{
    /// <summary>
    /// Class Graphics Editor
    /// </summary>
    class GraphicEditor
    {
        /// <summary>
        /// Draws rectangle
        /// </summary>
        public void DrawRectangle()
        {
            Shape shape = new Rectangle();
            shape.Draw();
        }

        /// <summary>
        /// Draws circle
        /// </summary>
        public void DrawCircle()
        {
            Shape shape = new Circle();
            shape.Draw();
        }
    }
}
