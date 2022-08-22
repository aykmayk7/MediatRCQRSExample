namespace Example.Application.Queries.Examples.GetExample
{
    public class GetExampleCommandResponse
    {
        public GetExampleCommandResponse(int id, string? name, string? surname, int? age, string? mail, string? telephone)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Mail = mail;
            Telephone = telephone;
        }

        public int Id { get; private set; }
        public string? Name { get; private set; }
        public string? Surname { get; private set; }
        public int? Age { get; private set; }
        public string? Mail { get; private set; }
        public string? Telephone { get; private set; }
    }
}
