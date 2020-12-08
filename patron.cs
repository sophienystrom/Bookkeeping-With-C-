using System;
using System.Collections.Generic;
using System.Linq;

class Patron : Person
{

public string LibraryId {get; set;}
public DateTime StartDate {get;set;}
public DateTime EndDate {get; set;}
public bool IsAccountActive {get; set;}
public double FineAmountDue {get; set;}
public List<Rental> RentalList = new List<Rental>();

public Patron(string fname, string lname, string libraryid) :base(fname, lname)
{
  LibraryId = libraryid;
  StartDate = DateTime.Today;
  IsAccountActive = true;
}

public void Display()
{
 Console.WriteLine("Library Id = {0}. Patron name = {1} {2}", LibraryId, FirstName, LastName);
}

public void AddToRentalCart(Book BookObject, DateTime DueDate)
{
 Rental BookRented = new Rental(BookObject);
 RentalList.Add(BookRented);
 Console.WriteLine("Added to rental cart: {0} for patron {1} {2}", BookObject, FirstName, LastName);
}

// will fix to not give values when there is no book in cart

public void RemoveFromCart(Book BookObject){
Rental BookRented = new Rental(BookObject);
RentalList.Remove(BookRented);
Console.WriteLine("Removed from rental cart: {0} for patron {1} {2}", BookObject, FirstName, LastName);
}




















}