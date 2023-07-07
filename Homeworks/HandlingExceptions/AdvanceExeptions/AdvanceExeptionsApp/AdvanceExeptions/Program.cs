namespace AdvanceExeptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In this program, we will capture exceptions");
            Console.WriteLine("This program was created by Juan Jose Figueroa. ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Call Method");

            try
            {
                Console.Write("How old are you? ");
                int age = Convert.ToInt32(Console.ReadLine());
                GetAge(age);
                GetFile();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Any Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("The program End... Thanks for comming ");
            }


            Console.ReadLine();

        }
        public static void GetFile()
        {
            throw new FileNotFoundException("The File was not Found");
        }
        public static void GetAge(int age)
        {
            if (age < 0)
            {
              throw new IndexOutOfRangeException("You are out of the appropriate range");
            }
            else
            {
                Console.WriteLine($"Yor age is { age }");
            }
        }
    }
}