using MMS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MMS.Data.Services
{
    public class InMemoryData : IMemberService
    {
        List<Member> InMemoryMembers;

        public InMemoryData()
        {
            InMemoryMembers = new List<Member>()
            {
                new Member { Id = 1, FirstName = "Ezra", LastName = "Houser", MiddleName = "J", MemberType = MemberType.Adult, StreetAddress = "123 Gumdrop Lane", ApartmentNum = "N/A", City = "Babylon", State = "Atlantia", ZipCode = 12345  },
                new Member { Id = 1, FirstName = "Rita", LastName = "Houser", MiddleName = "J", MemberType = MemberType.Youth, StreetAddress = "123 Gumdrop Lane", ApartmentNum = "N/A", City = "Babylon", State = "Atlantia", ZipCode = 12345  },
                new Member { Id = 1, FirstName = "Penny", LastName = "Houser", MiddleName = "J", MemberType = MemberType.Elder, StreetAddress = "123 Gumdrop Lane", ApartmentNum = "N/A", City = "Babylon", State = "Atlantia", ZipCode = 12345  },
                new Member { Id = 1, FirstName = "Biddy", LastName = "Houser", MiddleName = "J", MemberType = MemberType.Infant, StreetAddress = "123 Gumdrop Lane", ApartmentNum = "N/A", City = "Babylon", State = "Atlantia", ZipCode = 12345  }
            };
        }

        public IEnumerable<Member> GetAll()
        {
            return InMemoryMembers.OrderBy(m => m.FirstName);
        }
    }
}
