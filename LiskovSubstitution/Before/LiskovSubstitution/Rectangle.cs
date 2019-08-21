namespace LiskovSubstitution
{
   
    public class Rectangle
    {
        
        public int Width { get; set; }
        public int Hight { get; set; }
        public Rectangle()
        {

        }
        public Rectangle(int hight,int width)
        {
            Width = width;
            Hight = hight;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}:{Width},{nameof(Hight)}:{Hight}";
        }
    }
}
