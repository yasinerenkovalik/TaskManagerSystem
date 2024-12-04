using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerSystem.Domain.Entities
{
    public class TeamMembers:BaseEntity
    {
        public Guid TeamId { get; set; }
        public Guid UserId { get; set; }
        public int Role { get; set; }
    }
}
