using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Object.Models;

namespace Data_Access.Repository
{
    public interface IMemberRepository
    {
        public List<Member> GetMembers();
        IEnumerable<Member> SearchMemByName(string memName);
        public Member GetMemberByID(string id);
        public Member GetMemberByEmail(string email);
        public void AddMember(Member member);
        public void UpdateMember(Member member);
        public void RemoveMember(Member member);
    }
}
