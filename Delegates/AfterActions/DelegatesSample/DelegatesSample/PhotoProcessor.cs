using System;
namespace DelegatesSample
{
    public class PhotoProcessor
    {
    
        public void Process(string path,Action<Photo> photoFilterHandler )
        {
            var photo = Photo.Load(path);
            photoFilterHandler(photo);
            photo.Save();
        }
    }
}
