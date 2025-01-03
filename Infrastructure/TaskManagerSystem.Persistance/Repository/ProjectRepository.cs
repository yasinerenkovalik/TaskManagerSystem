using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Application.Interface.Repository;
using TaskManagerSystem.Domain.Entities;
using TaskManagerSystem.Persistance.Context;

namespace TaskManagerSystem.Persistance.Repository
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(TaskManagerSystemContext appContext) : base(appContext)
        {
        }
    }
}
