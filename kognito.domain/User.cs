namespace kognito.domain;

public class User : BaseObject
{
    public string FullName { get; set; }
    public DateTimeOffset BirthDate { get; set; }
    public string Cpf { get; set; }
}
