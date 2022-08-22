using MediatR;

namespace Example.Application.Queries.Examples.GetExample
{
    internal class GetExampleCommandHandler : IRequestHandler<GetExampleCommand, GetExampleCommandResponse>
    {
        public async Task<GetExampleCommandResponse> Handle(GetExampleCommand request, CancellationToken cancellationToken)
        {
            var response = new GetExampleCommandResponse(1, "CQRS", "MediatR", 2, "cqr@mediatr.com", "+99 888 777 66 55");

            return response;
        }
    }
}
