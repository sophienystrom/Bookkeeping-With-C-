using System;
using System.Collections.Generic;
using System.Linq;

class Rental {

public Book BookRented {get; set;}
public DateTime DateRented {get; set;}
public DateTime DateDue {get; set;}

public Rental(Book BookObject)
{

}

public Rental(Book BookObject, DateTime daterented, DateTime datedue){
BookRented = BookObject;
DateRented = daterented;
DateDue = datedue;
}






















}