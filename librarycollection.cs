using System;
using System.Collections.Generic;
using System.Linq;

class LibraryCollection {

private List<Patron> PatronList = new List<Patron>();
private List<Book> booklist = new List<Book>();

public void AddPatron(Patron PatronObject)
{
  PatronList.Add(PatronObject);
  Console.WriteLine("Patron successfully added");
}

public void RemovePatron(Patron PatronObject)
{
  PatronList.Remove(PatronObject);
  Console.WriteLine("Patron successfully removed");
}

// displaypatroninfo here

public void AddToCollection(Book BookObject) {
booklist.Add(BookObject);
Console.WriteLine("Added book successfully");
}

public void RemoveFromCollection(Book BookObject) {
booklist.Remove(BookObject);
Console.WriteLine("Book removed successfully");
}

public void DisplayCollection()
{
  foreach(Book BookObject in booklist)
  {
    Console.WriteLine(BookObject.Title);
  }
}

// for each book the patron has in their rental cart it will be removed from the library Collection

/* public void ProcessRental(Book BookObject)
{
  booklist.Remove(BookObject);
} 

public void ProcessReturns(Patron PatronObject, Book BookObject)
{
  Rental BookRented = RentalList.Find(BookRented=>BookRented.BookObject);
  if (DueDate <= DateTime.Today)
  {
    FineAmountDue = FineAmountDue + 10;
    Console.WriteLine("Fine of $10 added onto account");
  }
  RentalList.Remove(BookObject);
  booklist.Add(BookObject);
  Console.WriteLine("Processed rental for {0}", BookObject)
}



*/

} 