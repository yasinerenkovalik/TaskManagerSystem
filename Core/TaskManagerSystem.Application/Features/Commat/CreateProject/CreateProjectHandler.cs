using AutoMapper;
using MediatR;
using TaskManagerSystem.Application.Wrapper;
using TaskManagerSystem.Application.Interface.Repository;
using TaskManagerSystem.Domain.Entities;
using TaskManagerSystem.Application.Dtos;
using TaskManagerSystem.Application.Features.Command.CreateProject;
using Applicatino.Wrapper;

namespace TaskManagerSystem.Application.Features.Command.CreateProject
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, BaseResponse<CreateProductViewDto>>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public CreateProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _mapper = mapper;
            _projectRepository = projectRepository;
        }

        public async Task<BaseResponse<CreateProductViewDto>> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
 
            var project = _mapper.Map<Project>(request);
       
       

            await _projectRepository.AddAsync(project);

  
            var responseViewModel = _mapper.Map<CreateProductViewDto>(project);

            return new SuccessResponse<CreateProductViewDto>(responseViewModel, "Proje başarıyla oluşturuldu.");
        }
    }
}
