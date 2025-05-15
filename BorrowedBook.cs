using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elib
{
    public class BorrowedBook
    {
        public int BorrowID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }  // Nullable
        public string? Status { get; set; }

        public override string ToString()
        {
            return $"Book ID: {BookID}, Borrowed on: {BorrowDate.ToShortDateString()}, Status: {Status}";
        }
    }
}
