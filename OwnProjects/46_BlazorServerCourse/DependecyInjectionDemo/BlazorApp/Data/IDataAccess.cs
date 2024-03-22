namespace BlazorApp.Data
{
    public interface IDataAccess
    {
        int Age { get; set; }

        int GetUserAge();
    }
}