
using System;
using Modifiers;

namespace Modifiers {
    class Program {
        static void Main(string[] args) {
            // create a new object instances using the "new" operator
            // Book b1 = new Book("War and Peace", "Leo Tolstoy", 824);
            // Book b2 = new Book("Peace", "Tolstoy", 284);
            // Book b3 = new Book("War", "Leo", 428);

            //call a method on the object
            // Console.WriteLine(b1.GetDescription());
            // Console.WriteLine(b2.GetDescription());
            // Console.WriteLine(b3.GetDescription());
             // create a new Book instance
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            b1._name = "Aldous Huxley";
            Console.WriteLine(b1.GetDescription());

            // set data using functions instead of accessing fields directly
            b1.SetName("Grapes of Wrath");
            b1.SetAuthor("John Steinbeck");
            b1.SetPagecount(464);
            Console.WriteLine(b1.GetDescription());

        }
    }
}

// practice adding dependencies to console app


// Console.WriteLine("Hello, World!");

// static void HumanizeQuantities()
// {
//     Console.WriteLine("case".ToQuantity(0));
//     Console.WriteLine("case".ToQuantity(1));
//     Console.WriteLine("case".ToQuantity(5));
// }

// static void HumanizeDates()
// {
//     Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
//     Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
//     Console.WriteLine(TimeSpan.FromDays(1).Humanize());
//     Console.WriteLine(TimeSpan.FromDays(16).Humanize());
// }

// Console.WriteLine("Dates");
// HumanizeDates();

// Console.WriteLine("Quantities");
// HumanizeQuantities();


