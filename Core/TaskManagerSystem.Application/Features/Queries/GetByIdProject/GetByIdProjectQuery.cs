using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Application.Dtos;
using TaskManagerSystem.Application.Wrapper;

namespace TaskManagerSystem.Application.Features.Queries.GetByIdProject
{
    public class GetProjectByIdQuery : IRequest<BaseResponse<GetByIdProjectDto>>
    {
        public Guid Id { get; set; }
    }
}
