
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

namespace TaskManagerSystem.Application.Features.Commat.DeleteProject
{
    public class DeleteProjectHandler:IRequestHandler<DeleteProjectCommand,BaseResponse<DeleteProjectDto>>
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;
        public DeleteProjectHandler(IProjectRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<BaseResponse<DeleteProjectDto>> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            
            var project = await _repository.GetByIdAsync(request.id);

            if (project == null)
            {
                return new BaseResponse<DeleteProjectDto>(true, "geldi", new DeleteProjectDto(), null);
            }
            

            await _repository.DeleteAsync(project.Id);

            return new BaseResponse<DeleteProjectDto>(true, "geldi", new DeleteProjectDto(), null);
        }
    }

 
    }

