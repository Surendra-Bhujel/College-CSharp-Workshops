// Groups the code. The name matches the project.
namespace PersonalDetails
{
    // Holds the code for this program.
    class Program
    {
        // The starting point. The runtime calls Main first.
        public static void Main(string[] args)
        {
            // Local variables: each one stores a single detail.
            // Text uses string; a whole number uses int.
            string name = "Surendra Bhujel";
            string address = "Chauthe Pokhara";
            string contactNumber = "9829887876";
            string email = "surendra.bhujel.a24@icp.edu.np";
            string college = "Informatics college Pokhara";
            string course = "BIT";
            int yearOfStudy = 3;

            // Print the heading line.
            Console.WriteLine("========== Personal Details ==========");

            // $"..." is string interpolation: {name} is replaced by the
            // variable's value. The spaces before ":" line up the labels.
            Console.WriteLine($"Name          : {name}");
            Console.WriteLine($"Address       : {address}");
            Console.WriteLine($"Contact Number: {contactNumber}");
            Console.WriteLine($"Email         : {email}");
            Console.WriteLine($"College       : {college}");
            Console.WriteLine($"Course        : {course}");
            Console.WriteLine($"Year of Study : {yearOfStudy}");

            // Task B: create a MotivationalQuote object.
            // The text in the brackets is passed to the constructor,
            // which stores it in the object's field.
            MotivationalQuote quote = new MotivationalQuote("Your motivational quote goes here.");

            // Call the method that prints the stored quote.
            quote.PrintQuote();
        }
    }
}