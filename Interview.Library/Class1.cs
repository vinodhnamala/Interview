using Interview.Library;

namespace Interview.Library
{
    public abstract class Class1
    {
        public void Invite()
        {
            Console.WriteLine($"Welcome from : {nameof(Class1)}");
        }

        public void Print()
        {

        }

        protected void Method1()
        {

        }



        //create the method for which I have no implementation in this class and 
        //will be implemented in derived --?-- class 

        
    }


    public class Class2 : Class1
    {
        public void Greet()
        {

        }
        public void Test()
        {
            this.Print();
        }

        //create the method for which I can have implementation in this class and 
        //will be overriden in derived  class 
    }

    public class Class3 : Class2
    {

    }
}
