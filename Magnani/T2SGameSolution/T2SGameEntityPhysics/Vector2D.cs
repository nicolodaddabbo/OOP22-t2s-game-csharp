namespace T2SGameEntityPhysics
{
    /// <summary>
    /// This class represents a vector in a two-dimensional space.
    /// </summary>
    public class Vector2D
    {

        /// <summary>
        /// Coordinate of the vector in x axis.
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Coordinate of the vector in y axis.
        /// </summary>
        public double Y { get; }

        /// <param name="x">Coordinate of the vector in x axis.</param>
        /// <param name="y">Coordinate of the vector in y axis.</param>
        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// This method sums the current vector with the given vector and returns the new
        /// vector.
        /// </summary>
        /// <param name="x">Coordinate of the vector in x axis.</param>
        /// <param name="y">Coordinate of the vector in y axis.</param>
        /// <returns>The resulting vector.</returns>
        /// <seealso cref="Sum(Vector2D)"/>
        public Vector2D Sum(double x, double y)
        {
            return new Vector2D(X + x, Y + y);
        }

        /// <summary>
        /// This method sums the current vector with the given vector and returns the new
        /// vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>The resulting vector.</returns>
        /// <seealso cref="Sum(double, double)"/>
        public Vector2D Sum(Vector2D vector)
        {
            return Sum(vector.X, vector.Y);
        }

        /// <summary>
        /// This method subtracts the current vector with the given vector and returns 
        /// the new vector.
        /// </summary>
        /// <param name="x">Coordinate of the vector in x axis.</param>
        /// <param name="y">Coordinate of the vector in y axis.</param>
        /// <returns>The resulting vector.</returns>
        /// <seealso cref="Sub(Vector2D)"/>
        public Vector2D Sub(double x, double y)
        {
            return new Vector2D(X - x, Y - y);
        }

        /// <summary>
        /// This method subtracts the current vector with the given vector and returns 
        /// the new vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>The resulting vector.</returns>
        /// <seealso cref="Sub(double, double)"/>
        public Vector2D Sub(Vector2D vector)
        {
            return Sub(vector.X, vector.Y);
        }

        /// <summary>
        ///This method multiplies the current vector with the given value and returns
        /// the new vector.
        /// </summary>
        /// <param name="scalar">The value to multiply.</param>
        /// <returns>The resulting vector.</returns>
        public Vector2D Mul(double scalar)
        {
            return new Vector2D(X * scalar, Y * scalar);
        }

        /// <summary>
        /// This method returns the distance between the current point and the given
        /// point.
        /// </summary>
        /// <param name="x">Coordinate of the vector in x axis.</param>
        /// <param name="y">Coordinate of the vector in y axis.</param>
        /// <returns>The resulting distance.</returns>
        /// <seealso cref="Distance(Vector2D)"/>
        public double Distance(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x - X, 2) + Math.Pow(y - Y, 2));
        }

        /// <summary>
        /// This method returns the distance between the current point and the given
        /// point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The resulting distance.</returns>
        /// <seealso cref="Distance(double, double)"/>
        public double Distance(Vector2D point)
        {
            return Distance(point.X, point.Y);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return obj is Vector2D d &&
                   X == d.X &&
                   Y == d.Y;
        }

        /// <inheritdoc />
        public override string? ToString()
        {
            return base.ToString() + "[x=" + X + ", y=" + Y + "]";
        }

    }
}