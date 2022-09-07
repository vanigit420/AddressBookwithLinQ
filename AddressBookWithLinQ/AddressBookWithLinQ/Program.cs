// See https://aka.ms/new-console-template for more information
using ADDRESSBOOKwithLINQ;

Console.WriteLine("Hello, World!");


//AddressBook addressbook1 = new AddressBook();
//addressbook1.AddToDataTable();


List<Contact> contactList = new List<Contact>()
    { new Contact(){FirstName=Console.ReadLine(), LastName="Biranwar", Address="Katraj", City="Pune", State="Maharashtra", ZipCode="123456", PhoneNumber="1234567893", Email="abcd@gmail.com" } };

AddressBook1 addressbook = new AddressBook1();
addressbook.Addressbook(contactList);
Console.ReadKey();