using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerSystem.Domain.Entities
{
    public  class Project:BaseEntity
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
 
    }
}
