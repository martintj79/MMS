using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace MMS.Data.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }
        public MemberType MemberType { get; set; }
        public string StreetAddress { get; set; }
        public string ApartmentNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? ZipCode { get; set; }

    }
}
