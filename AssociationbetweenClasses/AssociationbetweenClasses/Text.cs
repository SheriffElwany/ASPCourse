namespace AssociationbetweenClasses
{
    public class Text:PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
        public void AddHyperLink(string url)
        {
            System.Console.WriteLine($"Added link {url}");
        }

    }
}
