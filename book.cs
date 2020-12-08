using System;
using System.Collections.Generic;
using System.Linq;

class Book {

public string ISBN {get; set;}
public string Title {get; set;}
public string AuthorInfo;
public virtual DateTime PublishedOn {get; set;}
public string PublishedBy {get; set;}

public Book(string isbn, string title, string authorinfo): this(isbn, title, authorinfo, DateTime.Today, "unknown")
{

}

public Book(string isbn, string title, string authorinfo, DateTime publishedon, string publishedby) {
  ISBN = isbn;
  Title = title;
  AuthorInfo = authorinfo;
  PublishedOn = publishedon;
  PublishedBy = publishedby;
}

public void Display() {
  Console.WriteLine ("The book '{0}' was written by {1} and published on {2}",  Title, AuthorInfo, PublishedOn);
}

























}