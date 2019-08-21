namespace DelegatesSample
{
    public class PhotoProcessor
    {
       
        public void Process(string path)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.ApplyReszie(photo);

            photo.Save();
        }
    }
}
