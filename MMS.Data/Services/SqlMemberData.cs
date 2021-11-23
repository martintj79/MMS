using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MMS.Data.Models;

namespace MMS.Data.Services
{
    public class SqlMemberData : IMemberService
    {
        private readonly MMSDBContext db;
        public SqlMemberData(MMSDBContext db)
        {
            this.db = db;             
        }
        public void Add(Member member)
        {
            db.Members.Add(member);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var member = db.Members.Find(id);
            db.Members.Remove(member);
            db.SaveChanges();

        }

        public Member Get(int id)
        {
            return db.Members.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Member> GetAll()
        {
            return from r in db.Members
                   orderby r.LastName
                   select r;
        }

        public void Update(Member member)
        {
            var entry = db.Entry(member);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
