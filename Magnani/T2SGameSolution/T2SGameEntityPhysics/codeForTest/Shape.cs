namespace T2SGameEntityPhysics
{
    /// <summary>
    /// This interface models a shape usefull for managing collisions.
    /// </summary>
    public class Shape
    {
        /// <summary>
        /// The center of the shape.
        /// </summary>
        public Vector2D Center { get; set; }

        /// <param name="center">The center of the shape.</param>
        public Shape(Vector2D center)
        {
            Center = center;
        }

        /// <summary>
        /// Checking if the current shape is colliding with the given shape.
        /// </summary>
        /// <param name="shape">The other shape to check if the current is colliding.
        /// </param>
        /// <returns>True if collision has been detected, otherwise false.</returns>
        public Boolean IsColliding(Shape shape)
        {
            return Center == shape.Center;
        }

    }
}