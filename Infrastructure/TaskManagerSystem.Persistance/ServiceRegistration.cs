using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Application.Interface.Repository;
using TaskManagerSystem.Persistance.Repository;

namespace TaskManagerSystem.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IProjectRepository, ProjectRepository>();

        }

    }
}
