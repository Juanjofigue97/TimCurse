namespace BlazorApp.Models
{
    public class SampleModel
    {
        public string SamplePassword { get; set; }
        public int SampleInt { get; set; }
        public double SampleDouble { get; set; }
        public bool SampleBool { get; set; } = false;
        public DateTime SampleDateTime { get; set; } = DateTime.Now;

        public int DropDownValue { get; set; }
    }
}
