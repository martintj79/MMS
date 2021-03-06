using MMS.Data.Models;
using System.Collections.Generic;
using System.Text;

namespace MMS.Data.Services
{
    public interface IMemberService
    {
        IEnumerable<Member> GetAll();
        Member Get(int id);
        void Add(Member member);
        void Update(Member member);
        void Delete(int id);
    }
}
