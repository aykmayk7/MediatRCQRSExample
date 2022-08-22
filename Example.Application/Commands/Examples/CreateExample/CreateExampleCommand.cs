using MediatR;

namespace Example.Application.Commands.Examples.CreateExample
{
    public class CreateExampleCommand : IRequest<CreateExampleCommandResponse>
    {
        public CreateExampleCommand(string? name, string? surname, int? age, string? mail, string? telephone)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Mail = mail;
            Telephone = telephone;
        }

        public string? Name { get; private set; }
        public string? Surname { get; private set; }
        public int? Age { get; private set; }
        public string? Mail { get; private set; }
        public string? Telephone { get; private set; }

    }
}
