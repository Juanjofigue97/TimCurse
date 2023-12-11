namespace PeopleModelAPI.Model
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"{ FirstName } { LastName } : { IsActive } ";
        }
    }
}
