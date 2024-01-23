using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Domain.Entities
{
    public abstract class CommonEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid IdUserCreated { get; set; }
        public User? UserCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid IdUserUpdated { get; set; }
        public User? UserUpdated { get; set; }

    }
}
