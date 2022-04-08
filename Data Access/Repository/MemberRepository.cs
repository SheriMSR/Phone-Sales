using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Object.Models;

namespace Data_Access.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(Member member) => MemberDAO.Instance.AddMember(member);

        public Member GetMemberByEmail(string email) => MemberDAO.Instance.GetMemberByEmail(email);

        public Member GetMemberByID(string id) => MemberDAO.Instance.GetMemberByID(id);

        public List<Member> GetMembers() => MemberDAO.Instance.GetMembers();

        public void RemoveMember(Member member) => MemberDAO.Instance.RemoveMember(member);

        public IEnumerable<Member> SearchMemByName(string memName) => MemberDAO.Instance.SearchMemberByName(memName);

        public void UpdateMember(Member member) => MemberDAO.Instance.UpdateMember(member);
    }
}
