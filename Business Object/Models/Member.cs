using System;
using System.Collections.Generic;

#nullable disable

namespace Business_Object.Models
{
    public partial class Member
    {
        public Member()
        {
            Orders = new HashSet<Order>();
        }

        public string MemberId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? PhoneNumber { get; set; }
        public string MemberRole { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
