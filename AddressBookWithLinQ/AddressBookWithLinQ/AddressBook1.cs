namespace ADDRESSBOOKwithLINQ
{
    internal class AddressBook1
    {



        public void Addressbook(List<Contact> listcontact)
        {
            var Address = (from contact in listcontact
                           orderby contact
                           select contact);


            foreach (var list in Address)
            {
                Console.WriteLine("FirstName:- " + list.FirstName + " " + "LastName:- " + list.LastName
                    + " " + "Address:- " + list.Address + " " + "City:- " + list.City + " " + "State:- " + list.State + " " + "ZipCode:-" + list.ZipCode + " " + "PhoneNumber:-" + list.PhoneNumber + " " + "Email:-" + list.Email);
            }






        }



    }
}