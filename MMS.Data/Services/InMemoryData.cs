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

        public void Add(Member member)
        {
            InMemoryMembers.Add(member);
            member.Id = InMemoryMembers.Max(r => r.Id) + 1;
        }

        public void Update(Member member)
        {
            var existing = Get(member.Id);
            if (existing != null)
            {
                existing.FirstName = member.FirstName;
                existing.LastName = member.LastName;
                existing.MiddleName = member.MiddleName;
                existing.StreetAddress = member.StreetAddress;
                existing.MemberType = member.MemberType;
                existing.State = member.State;
                existing.ZipCode = member.ZipCode;
                existing.City = member.City;
                existing.ApartmentNum = member.ApartmentNum;
            }
        }

        public Member Get(int id)
        {
            return InMemoryMembers.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Member> GetAll()
        {
            return InMemoryMembers.OrderBy(m => m.FirstName);
        }

        public void Delete(int id)
        {
            var member = Get(id);
            if(member != null)
            {
                InMemoryMembers.Remove(member);
            }
        }
    }
}
