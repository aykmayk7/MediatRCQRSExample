using MediatR;

namespace Example.Application.Commands.Examples.CreateExample
{
    internal class CreateExampleCommandHandler : IRequestHandler<CreateExampleCommand, CreateExampleCommandResponse>
    {
        public async Task<CreateExampleCommandResponse> Handle(CreateExampleCommand request, CancellationToken cancellationToken)
        {
            /* 
             * you can write the db logic in here. for deo purpose :)
             * im returning hard coded value (;
            */

            return new CreateExampleCommandResponse(1);            
        }
    }
}
