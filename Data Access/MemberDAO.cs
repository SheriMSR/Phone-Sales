using System;
using System.Collections.Generic;
using System.Linq;
using Business_Object.Models;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Member> GetMembers()
        {
            var members = new List<Member>();
            try
            {
                using var context = new PhoneSaleManagementContext();
                members = context.Members.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }
        public Member GetMemberByID(string id)
        {
            Member member = null;
            try
            {
                using var context = new PhoneSaleManagementContext();
                member = context.Members.SingleOrDefault(e => e.MemberId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public Member GetMemberByEmail(string email)
        {
            Member member = null;
            try
            {
                using var context = new PhoneSaleManagementContext();
                member = context.Members.SingleOrDefault(e => e.Email == email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public void AddMember(Member member)
        {
            try
            {
                Member pro = GetMemberByID(member.MemberId);
                Member pro2 = GetMemberByEmail(member.Email);
                if (pro == null && pro2 == null)
                {
                    using var context = new PhoneSaleManagementContext();
                    context.Members.Add(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This member has already existed. Please change the ID or Email !");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateMember(Member member)
        {
            try
            {
                var check = GetMemberByID(member.MemberId);
                Member pro2 = GetMemberByEmail(member.Email);
                if (check == null)
                {
                    throw new Exception("This member is not existed.");
                }
                //else if (pro2 != null)
                else if (!pro2.MemberId.Equals(member.MemberId))
                {
                    throw new Exception("This Email has been used ! Please change it.");
                }
                else
                {
                    using var context = new PhoneSaleManagementContext();
                    context.Members.Update(member);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveMember(Member member)
        {
            try
            {
                var check = GetMemberByID(member.MemberId);
                if (check != null)
                {
                    using var context = new PhoneSaleManagementContext();
                    context.Members.Remove(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This member is not existed.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Member> SearchMemberByName(string mname)
        {
            var mems = MemberDAO.Instance.GetMembers();
            IEnumerable<Member> list = from member in mems
                                       where (member.FullName.ToLower().Contains(mname.ToLower()))
                                       select member;
            return list;
        }

    }
}
