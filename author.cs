using System;
using System.Collections.Generic;
using System.Linq;

class Author : Person 
{

public Book Title {get; set;}
private List<Book> BookList = new List<Book>();

public Author() : base()
{
}

public Author(string fname, string lname) :base(fname, lname)
{
}

public void DisplayInfo()
{
  Console.WriteLine("Name: {0} {1}. Email: {2}", FirstName, LastName, Email);
}

public void DisplayBooks() 
{
 Console.WriteLine("Author's books:");
 foreach(Book BookObject in BookList)
 {
 Console.WriteLine(BookObject.Title);
 }
}

public void AddBook(Book BookObject)
{
 BookList.Add(BookObject);
 Console.WriteLine("Book added to author's registry");
} 

// change to use ISBN

public void RemoveBook(Book BookObject)
{
 BookList.Remove(BookObject);
 Console.WriteLine("Book removed from author's registry");
}


}