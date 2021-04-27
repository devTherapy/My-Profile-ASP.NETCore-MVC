namespace Portfolio.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactValue { get; set; }
        public Contact(int contactId, string contactName, string contactValue)
        {
            ContactId = contactId;
            ContactName = contactName;
            ContactValue = contactValue;
        }
    }
}