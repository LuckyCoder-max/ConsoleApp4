using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Status { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            Status = "Available";
        }
        public void Reserve()
        {
            if (Status == "Available")
            {
                Status = "Reserved";
                Console.WriteLine($"{Title} has been reserved.");
            }
            else
            {
                Console.WriteLine($"{Title} is not available for reservation.");
            }
        }

        public void CancelReservation()
        {
            if (Status == "Reserved")
            {
                Status = "Available";
                Console.WriteLine($"Reservation for {Title} has been canceled.");
            }
            else
            {
                Console.WriteLine($"No reservation found for {Title}.");
            }
        }
    }
}
