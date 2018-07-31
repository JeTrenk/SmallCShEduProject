namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoProcessorHandler(Photo photo);
        public void Process(string path, PhotoProcessorHandler processorHandler)
        {
            var photo = Photo.Load(path, new MemoryStream());

            var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            processorHandler(photo);

            photo.Save();
        }
    }
}
