using System;

namespace DataAccess.Entity
{
    public class Contact
    {
        public int Id { get; set; }
        public int ParentUserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }        
        public string Address { get; set; }
        public string Company { get; set; }        
    }    
}
