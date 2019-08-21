using System;

namespace DelegatesSample
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }
        public void Save()
        {
            Console.WriteLine("Photo Saved");
        }
    }
}
