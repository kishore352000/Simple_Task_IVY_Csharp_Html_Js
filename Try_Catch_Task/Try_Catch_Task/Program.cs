namespace Try_Catch_Task
{
    internal class Try_catch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of Try catch blocks");
            // By using a try-catch block in C#, we are handling exceptions that could happen in our code.
            //  The try block should contain any suspicious code that may likely produce an exception.

            try
            {
                int a = 5;
                int result = a/0;
            }
            //the catch block contains any action or operation we want to execute when the code in the try block raises an exception.
            catch (DivideByZeroException e)
            {
                Console.WriteLine( e.Message);
            }
        }
    }
}
