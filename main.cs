using System;

/* yes I should've spent more time on this and I regret missing a few classes. But it's ok I am making it my goal to fix this code! I got it I got it*/

class MainClass {
 public static void Main (string[] args) {

 Book BookOne = new Book("1000", "Book One", "Author");
 Book BookTwo = new Book("1001", "Book Two", "Author");
 Book BookThree = new Book("1002", "Book Three", "Author");
 Book BookFour = new Book("1003", "Book Four", "Author", Convert.ToDateTime("12/02/2020"), "Sophie Publishing");
 Book BookFive = new Book("1004", "Book Five", "Author", Convert.ToDateTime("12/02/2020"), "Sophie Publishing");
 Book BookSix = new Book("1005", "Book Six", "Author", Convert.ToDateTime("12/02/2020"), "Sophie Publishing");

 BookOne.Display();
 BookFour.Display();

 Author AuthorOne = new Author("Author", "One");
 AuthorOne.Email = "AuthorOne@gmail.com";
 AuthorOne.DisplayInfo();
 AuthorOne.AddBook(BookOne);
 AuthorOne.AddBook(BookThree);
 AuthorOne.AddBook(BookFive);
 AuthorOne.DisplayBooks();
 AuthorOne.RemoveBook(BookOne);
 AuthorOne.DisplayBooks();

 Author AuthorTwo = new Author("Author", "Two");
 AuthorTwo.Email = "AuthorTwo@gmail.com";
 AuthorTwo.DisplayInfo();
 AuthorTwo.AddBook(BookTwo);
 AuthorTwo.AddBook(BookFour);
 AuthorTwo.AddBook(BookSix);
 AuthorTwo.DisplayBooks();

Patron patron1 = new Patron("Patron", "One", "0000");
Patron patron2 = new Patron("Patron", "Two", "1111");
Patron patron3 = new Patron("Patron", "Three", "2222");
Patron patron4 = new Patron("Patron", "Four", "3333");
Patron patron5 = new Patron("Patron", "Five", "4444");
 

patron1.AddToRentalCart(BookOne, Convert.ToDateTime("12/07/2020"));
patron1.RemoveFromCart(BookOne);

LibraryCollection librarycollection = new LibraryCollection();

librarycollection.AddPatron(patron1);
librarycollection.AddPatron(patron2);
librarycollection.AddPatron(patron3);
librarycollection.AddPatron(patron4);
librarycollection.AddPatron(patron5);

//librarycollection.DisplayPatronInfo();

librarycollection.RemovePatron(patron5);

//librarycollection.DisplayPatronInfo();

librarycollection.AddToCollection(BookOne);
librarycollection.AddToCollection(BookTwo);
librarycollection.AddToCollection(BookThree);
librarycollection.AddToCollection(BookFour);
librarycollection.AddToCollection(BookFive);
librarycollection.AddToCollection(BookSix);

librarycollection.DisplayCollection();

librarycollection.RemoveFromCollection(BookFive);

librarycollection.DisplayCollection();

patron1.AddToRentalCart(BookOne, Convert.ToDateTime("12/7/20"));
patron1.AddToRentalCart(BookTwo, Convert.ToDateTime("12/7/20"));
patron1.AddToRentalCart(BookThree,Convert.ToDateTime("12/7/20"));
patron1.RemoveFromCart(BookThree);
//librarycollection.ProcessRental(patron1);
librarycollection.DisplayCollection();
//librarycollection.ProcessReturns(patron1, BookTwo);
librarycollection.DisplayCollection();


    
  }
}