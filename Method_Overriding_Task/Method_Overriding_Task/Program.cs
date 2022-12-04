
namespace Method_Overriding_Task
{

    class Parent
    {
        //Virtual Function (Overridable Method) with virtual keyword
        public virtual void Show()
        {
            //Parent Class Logic Same for All Child Classes
            Console.WriteLine("Parent Class Method Executed");
        }
    }
    class Child : Parent
    {
        //Overriding Method by using override keyword
        public override void Show()
        {
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class  Method Executed");
        }
    }

   internal class Program
    {
        static void Main(string[] args)
        {
            Parent obj1 = new Parent();
            obj1.Show();
            Child obj2 = new Child();
            obj2.Show();
        }
    }
}