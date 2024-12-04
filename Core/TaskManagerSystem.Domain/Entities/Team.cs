using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerSystem.Domain.Entities
{
    public class Team:BaseEntity
    {
        public string TeamName { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
