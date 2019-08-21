namespace LiskovSubstitution
{
    public class Square:Rectangle
    {
        public new int Width
        {
            set { base.Width = base.Hight = value; }
        }
        public new int Hight
        {
            set {   base.Hight = base.Width = value; }
        }
    }
}
