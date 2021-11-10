using System;
using System.Collections.Generic;
using System.Text;


namespace MMS.Data.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public MemberType MemberType { get; set; }
        public string StreetAddress { get; set; }
        public string ApartmentNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

    }
}
