using Defining;
// See https://aka.ms/new-console-template for more information
Book b1 = new Book("How To Make Friends", "Faithful Gbeckor-Kove", 599, 39.9m);
Magazine m1 = new Magazine("How To Make Money", "Faithful Gbeckor-Kove", 599, 4.99m);
// b1.SetName("Things fall Apart");
// b1.SetAuthor("Adwoa Boateng");

// Console.WriteLine(b1.GetDescription());
// b2._name = "C# isn't that Fun!";
// Console.WriteLine(b2.GetDescription());

// After Using GETTERS AND SETTERS

// Console.WriteLine(b1.Name);
// Console.WriteLine(b1.Description);

// Set the ISBN and Price Properties
// b1.ISBN = "00015646";
// b1.Price = 24.99m;
// Console.WriteLine(b1.Price);
// Console.WriteLine(b1.ISBN);

// Change the Name and Pagecount
// b1.Name = "The Gods are Not To Blame";
// b1.PageCount=688;
// Console.WriteLine(b1.Description);

// AFTER SWITCHING TO INHERITANCE
Console.WriteLine($"{b1.Name},{b1.Author}");
Console.WriteLine($"{m1.Name},{m1.Publisher}");
Console.WriteLine(b1.GetDescription());
Console.WriteLine(m1.GetDescription());