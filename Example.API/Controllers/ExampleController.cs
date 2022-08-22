using Example.Application.Commands.Examples.CreateExample;
using Example.Application.Queries.Examples.GetExample;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public ExampleController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public async Task<GetExampleCommandResponse> Get(int id)
        {
            var response = await _mediatr.Send(new GetExampleCommand()
            {
                Id = id
            });

            return response;
        }

        [HttpPost]
        public async Task<CreateExampleCommandResponse> Create([FromBody] CreateExampleCommand command)
        {
            var request = new CreateExampleCommand(command.Name, command.Surname, command.Age, command.Mail, command.Telephone);

            var response = await _mediatr.Send(request);

            return response;
        }
    }
}
