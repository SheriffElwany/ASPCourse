namespace DelegatesSample
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, PhotoFilterHandler photoFilterHandler )
        {
            var photo = Photo.Load(path);
            photoFilterHandler(photo);
            photo.Save();
        }
    }
}
