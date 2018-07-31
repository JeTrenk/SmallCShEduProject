using System.IO;

namespace Delegates
{
    public class Photo
    {
        public Photo()
        {
        }
       
        private MemoryStream _memoryStream = new MemoryStream();

        public static MemoryStream Load(string path, MemoryStream memoryStream)
        {
            using (FileStream fs = File.OpenRead(path))
            {
                fs.CopyTo(memoryStream);
            }

            return memoryStream;
        }

        public MemoryStream MemoryPhoto
        {
            get
            {
                return this._memoryStream;
            }
    }
}