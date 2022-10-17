using System;
using System.Collections.Generic;

namespace netcoremvc.Models.DB
{
    public partial class User
    {
        public User()
        {
            Roles = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long Mobile { get; set; }
        public string Password { get; set; } = null!;

        public virtual ICollection<Role> Roles { get; set; }
    }
}
