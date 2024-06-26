﻿using System;
namespace Properties {
    class Program {
        static void Main(string[] args) {
            // create a new book object
            Book b1 = new Book("Love and Peace", "Spike Jonez", 655);

             // Access a couple of properties
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Description);

            // Set the ISBN and Price properties
            b1.ISBN = "100140447938";
            b1.Price = 24.95m;
            Console.WriteLine(b1.ISBN);
            Console.WriteLine(b1.Price);

            // Change the Name and Pagecount
            b1.Name = "Crime and Punishment";
            b1.Pagecount = 652;
            Console.WriteLine(b1.Description);
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Pagecount);
        }
    }
}