using System;

namespace Application.Contacts.Queries.GetContacts
{
    public class GetContactsModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int GenderId { get; set; }
        public string Phone { get; set; }
        public string PhoneBackup { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}