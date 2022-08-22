namespace Example.Application.Commands.Examples.CreateExample
{
    public class CreateExampleCommandResponse
    {
        public CreateExampleCommandResponse(int? id)
        {
            Id = id;
        }

        public int? Id { get; private set; }

    }
}
