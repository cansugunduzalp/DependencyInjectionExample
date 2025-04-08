namespace DependencyInjectionExample.Interfaces
{
    public interface IOgretmen
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetInfo();
    }
}
