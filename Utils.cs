using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Net.Http;

namespace elib
{
    public static class Utils
    {
        // New method to download image/binary image data (e.g., from a database BLOB) to a usable Image object in C#.
        public static Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null; // Just return null for any invalid image data
            }        
        }
    }
}
