
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

namespace TaskManagerSystem.Application.Features.Queries.GetByIdProject
{
    public class GetByIdProjectHandler : IRequestHandler<GetProjectByIdQuery, BaseResponse<GetByIdProjectDto>>

    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;
        public GetByIdProjectHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<GetByIdProjectDto>> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.Id);
            if (project == null) {
                return new BaseResponse<GetByIdProjectDto>(true,"geldi",new GetByIdProjectDto(),null);
            
            }
            var propjectDto=_mapper.Map<GetByIdProjectDto>(project);
            return new BaseResponse<GetByIdProjectDto>(true, "geldi", new GetByIdProjectDto(), null);
        }
    }
}
