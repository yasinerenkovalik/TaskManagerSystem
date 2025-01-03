using Applicatino.Wrapper;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Application.Dtos;
using TaskManagerSystem.Application.Interface.Repository;
using TaskManagerSystem.Application.Wrapper;

namespace TaskManagerSystem.Application.Features.Queries.QueryProject
{
    public class GetAllProjectHandler : IRequestHandler<GetAllProjectQuery, BaseResponse<List<GetAllProjectDto>>>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public GetAllProjectHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<GetAllProjectDto>>> Handle(GetAllProjectQuery request, CancellationToken cancellationToken)
        {
            // Veritabanından tüm projeleri al
            var projects = await _projectRepository.GetAllAysnc();

            // Domain entity'den DTO'ya mapleme
            var projectDtos = _mapper.Map<List<GetAllProjectDto>>(projects);

            return new SuccessResponse<List<GetAllProjectDto>>(projectDtos, "Projeler başarıyla getirildi.");
        }
    }
}
