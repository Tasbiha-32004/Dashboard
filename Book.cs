using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elib
{
    public class Book
    {
        public string? BookID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public int CategoryID { get; set; }
        public byte[]? ImageData { get; set; }
        public int CopiesAvailable { get; set; }

        // Optional: Override ToString() for easy display/debugging
        public override string ToString()
        {
            return $"{Title} by {Author} (Available: {CopiesAvailable})";
        }
    }
}
