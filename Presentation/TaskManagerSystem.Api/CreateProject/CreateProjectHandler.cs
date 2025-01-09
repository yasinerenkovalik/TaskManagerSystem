using AutoMapper;
using MediatR;
using TaskManagerSystem.Application.Wrapper;
using TaskManagerSystem.Application.Interface.Repository;
using TaskManagerSystem.Domain.Entities;
using TaskManagerSystem.Application.Dtos;
using TaskManagerSystem.Application.Features.Command.CreateProject;
using TaskManagerSystem.Application.Features.Commat.CreateProject;


namespace TaskManagerSystem.Application.Features.Command.CreateProject
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, BaseResponse<CreateProjectCommantResponse>>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public CreateProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
        }

        public async Task<BaseResponse<CreateProjectCommantResponse>> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
 
            var projectEntity = _mapper.Map<Project>(request);
       
       

            await _projectRepository.AddAsync(projectEntity);

  
            var responseViewModel = _mapper.Map<CreateProjectCommantResponse>(projectEntity);

            return new BaseResponse<CreateProjectCommantResponse>(true,"eklendi",new CreateProjectCommantResponse(),null);
        }
    }
}
