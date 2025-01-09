using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Application.Dtos;
using TaskManagerSystem.Application.Features.Command.CreateProject;
using TaskManagerSystem.Application.Features.Commat.CreateProject;
using TaskManagerSystem.Domain.Entities;

namespace TaskManagerSystem.Application.Mapping
{
    public class ProjectMapProfile : Profile
    {
        public ProjectMapProfile()
        {
            CreateMap<CreateProjectCommand, Project>();
            CreateMap<Project, CreateProjectCommantResponse>();


        }
    }
}
