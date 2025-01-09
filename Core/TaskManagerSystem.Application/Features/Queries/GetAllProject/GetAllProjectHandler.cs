
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
    public class GetAllProjectHandler : IRequestHandler<GetAllProjectQuery, BaseResponse<IEnumerable<GetAllProjectDto>>>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public GetAllProjectHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<IEnumerable<GetAllProjectDto>>> Handle(GetAllProjectQuery request, CancellationToken cancellationToken)
        {
            
            var projects = await _projectRepository.GetAllAysnc();

      
            var projectDtos = _mapper.Map<IEnumerable<GetAllProjectDto>>(projects);

            return new BaseResponse<IEnumerable<GetAllProjectDto>>(true, "Projeler başarıyla getirildi.",null,null);
        }
    }
}
