using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Application.Dtos;

using TaskManagerSystem.Domain.Entities;

namespace TaskManagerSystem.Application.Mapping
{
    public class ProjectMapping:Profile
    {
        public ProjectMapping()
        {
            CreateMap<CreateProductViewDto, Project>().ReverseMap();
            CreateMap<GetAllProjectDto, Project>().ReverseMap();
            CreateMap<Project, GetByIdProjectDto>().ReverseMap();


        }
    }
}
