namespace BlazorApp.Data
{
    public class DummyDataAccess : IDataAccess
    {
        public int Age { get; set; }

        public DummyDataAccess()
        {
            Random rnd = new Random();
            Age = rnd.Next(1, 120);
        }
        public int GetUserAge()
        {
            return Age;
        }
    }
}
