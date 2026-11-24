// Must use the same namespace as Program so the two files can see each other.
namespace PersonalDetails
{
    // Its own class, in its own file, outside the Program class.
    public class MotivationalQuote
    {
        // A field: private = only this class can use it,
        // readonly = it is set once and never changed afterwards.
        // The _ prefix is the C# convention for private fields.
        private readonly string _quote;

        // Constructor: same name as the class, no return type.
        // It runs automatically when the object is created with "new".
        public MotivationalQuote(string quote)
        {
            // Store the parameter in the field so it lives as long as the object.
            // "this." is not needed because the names are different.
            _quote = quote;
        }

        // public so Program can call it; void because it returns nothing.
        public void PrintQuote()
        {
            Console.WriteLine("========== Quote of the Day ==========");

            // \" prints a literal double-quote character inside a string.
            Console.WriteLine("\"" + _quote + "\"");
        }
    }
}