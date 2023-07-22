namespace DemoMVCPerson.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"Hello { FirstName } { LastName } !";
        }
    }
}
