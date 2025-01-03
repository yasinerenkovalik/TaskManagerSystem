using MediatR;
using TaskManagerSystem.Application.Dtos;
using TaskManagerSystem.Application.Wrapper;

namespace TaskManagerSystem.Application.Features.Command.CreateProject
{
    public record CreateProjectCommand(string Name, string Description, string Title) : IRequest<BaseResponse<CreateProductViewDto>>;
}
