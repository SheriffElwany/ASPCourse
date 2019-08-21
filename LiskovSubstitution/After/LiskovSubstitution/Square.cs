namespace LiskovSubstitution
{
    public class Square:Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Hight = value; }
        }
        public override int Hight
        {
            set {   base.Hight = base.Width = value; }
        }
    }
}
