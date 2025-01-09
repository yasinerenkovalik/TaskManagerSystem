using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagerSystem.Application.Features.Command.CreateProject;

using MediatR;
using TaskManagerSystem.Application.Features.Command.CreateProject;
using TaskManagerSystem.Application.Features.Queries.QueryProject;
using TaskManagerSystem.Application.Features.Queries.GetByIdProject;
using TaskManagerSystem.Application.Features.Commat.DeleteProject;
using TaskManagerSystem.Application.Dtos;
using TaskManagerSystem.Application.Features.Commat.CreateProject;
using TaskManagerSystem.Application.Wrapper;

namespace TaskManagerSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateProject([FromBody] CreateProjectCommand command)
        {
            var response = await _mediator.Send<BaseResponse<CreateProjectCommantResponse>>(command);

            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllProjects()
        {
            var query = new GetAllProjectQuery();
            var response = await _mediator.Send(query);

            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }
        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(GetProjectByIdQuery query)
        {
            
            var response = await _mediator.Send(query);

            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }
        [HttpGet("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var query = new DeleteProjectCommand(id);
            var response = await _mediator.Send(query);

            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }
    }
}
