
using MediatR;
using TaskManagerSystem.Application.Dtos;
using TaskManagerSystem.Application.Features.Commat.CreateProject;
using TaskManagerSystem.Application.Wrapper;

namespace TaskManagerSystem.Application.Features.Command.CreateProject;

public class CreateProjectCommand : IRequest<BaseResponse<CreateProjectCommantResponse>>
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; } 
    public string Description { get; set; }
    public string Title { get; set; }
}    
