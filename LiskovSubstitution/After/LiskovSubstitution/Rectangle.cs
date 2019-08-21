namespace LiskovSubstitution
{
   
    public class Rectangle
    {
        
        public virtual int Width { get; set; }
        public virtual int Hight { get; set; }
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
