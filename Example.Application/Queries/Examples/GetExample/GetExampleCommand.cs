using MediatR;

namespace Example.Application.Queries.Examples.GetExample
{
    public class GetExampleCommand : IRequest<GetExampleCommandResponse>
    {
        public int? Id { get; set; }
    }
}
