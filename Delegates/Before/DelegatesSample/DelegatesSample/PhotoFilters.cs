using System;

namespace DelegatesSample
{
    public class PhotoFilters
    {
        
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("photo Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("photo Contrast");
        }

        public void ApplyReszie(Photo photo)
        {
            Console.WriteLine("photo Resized");
        }
    }
}