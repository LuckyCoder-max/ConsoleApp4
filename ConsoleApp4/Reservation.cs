using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Reservation
    {
        public static void ReserveBook(Book book)
        {
            book.Reserve();
        }

        public static void CancelReservation(Book book)
        {
            book.CancelReservation();
        }
    }
}
