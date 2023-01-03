using _02_Lists.Models;

List<ContactPerson> contacts = new List<ContactPerson>();
ContactPerson contactPerson = new ContactPerson();

Console.Write("Ange förnamn: ");
contactPerson.FirstName = Console.ReadLine() ?? "";

Console.Write("Ange Efternamn: ");
contactPerson.LastName = Console.ReadLine() ?? "";

Console.Write("Ange E-postadress: ");
contactPerson.Email = Console.ReadLine() ?? "";

contacts.Add(contactPerson);



Console.Write("Ange förnamn: ");
contactPerson.FirstName = Console.ReadLine() ?? "";

Console.Write("Ange Efternamn: ");
contactPerson.LastName = Console.ReadLine() ?? "";

Console.Write("Ange E-postadress: ");
contactPerson.Email = Console.ReadLine() ?? "";

contacts.Add(contactPerson);

foreach (ContactPerson contact in contacts)
    Console.WriteLine($"{contact.FirstName} {contact.LastName} <{contact.Email}>");

