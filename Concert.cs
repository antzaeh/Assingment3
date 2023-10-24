using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Concert : IComparable
    {

        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public double Time { get; set; }
        public double Price { get; set; }


        public Concert()
        {
        }
        // Constructor with parameters
        public Concert(string title, string location, DateTime date, double time, double price)
        {
            Title = title;
            Location = location;
            Date = date;
            Time = time;
            Price = price;
        }

        public override string ToString()
        {
            string formattedDate = Date.ToString("MM/dd/yyyy");
            return Title + " at " + Location + " on " + formattedDate + " " + "Klo: " + Time + " Price: " + Price;
        }


        public static bool operator ==(Concert concert1, Concert concert2)
        {
            return concert1.Equals(concert2);
        }

        public static bool operator !=(Concert concert1, Concert concert2)
        {
            return !(concert1 == concert2);
        }

        public static bool operator <(Concert concert1, Concert concert2)
        {
            if (concert1.Price < concert2.Price)

                return true;
            return false;

        }
        public static bool operator >(Concert concert1, Concert concert2)
        {
            if (concert1.Price > concert2.Price)

                return true;
            return false;

        }
        public static Concert operator ++(Concert consert)
        {
            consert.Price += 5;

            return consert;

        }
        public static Concert operator --(Concert consert)
        {
            consert.Price -= 5;

            return consert;

        }
        public bool consertFound(double price)
        {
            return (price == this.Price);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is Concert concert &&
                   Title == concert.Title &&
                   Location == concert.Location &&
                   Date == concert.Date &&
                   Time == concert.Time &&
                   Price == concert.Price;
        }

        public override int GetHashCode()
        {
            int hashCode = 1065159126;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Location);
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + Time.GetHashCode();
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }
    }
}
