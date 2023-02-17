namespace T2SGameEntityPhysics
{
    public class Shape
    {
        public Vector2D Center { get; set; }

        public Shape(Vector2D center){
            Center = center;
        }

        public Boolean IsColliding(Shape shape){
            return Center == shape.Center;
        }

    }
}