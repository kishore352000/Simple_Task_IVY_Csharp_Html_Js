namespace Ref_Out_Task
{
    internal class Program
    {

        //out keyword is used when a called method has to update multiple parameter passed.
        //No need to initialize variable if out keyword is used.
        public static void update(out int value1)
        {
            value1 = 4;
        }
        //ref keyword is used when a called method has to update the passed parameter.
        //Before passing a variable as ref, it is required to be initialized otherwise compiler will throw error.
        public static void change(ref int value2)
        {
            value2=6;
        }
         static void Main(string[] args)
        {
            int value3;
            int value4=10;
            update(out value3);
            change(ref value4);
            Console.WriteLine("Updated value is:" +value3);
            Console.WriteLine("Changed value is:" +value4);
        }
    }
}
