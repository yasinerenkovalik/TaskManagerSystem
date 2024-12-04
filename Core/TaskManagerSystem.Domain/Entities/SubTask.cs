using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerSystem.Domain.Entities
{
    public class SubTask:BaseEntity
    {
        public Guid TaskId { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
      
    }
}
