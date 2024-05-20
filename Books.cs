using System;

namespace Defining 
{
    //public class - accessible throughout the code base
    public class Book
    {
        // declare fields to hold data
        string _name;
        string _author;
        int _pagecount;

        // classes have one or more constructors
        public Book(string name, string author, int pages) {
            _name = name;
            _author =  author;
            _pagecount = pages;
        }
    
        // add methods used to operate on the class and data
        public string GetDescription() {
            return $"{_name} by {_author} pages {_pagecount}";
        }
    }


}