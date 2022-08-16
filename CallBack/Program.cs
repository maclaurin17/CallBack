namespace CallBack
{
    /// <summary>
    /// This program demonstrates the use of delegate as a callback. 
    /// The callback delegate updates the Program class about the CallBackTest class.
    /// </summary>
    internal class Program
    {
       
        static void Main(string[] args)
        {
            CallBackTest obj = new CallBackTest();
            obj.LongRunning(callback);
        }
        static void callback(int i) // The callback delegate informs the program class about updates on CallBackTest class 
        {
            Console.WriteLine(i);
        }
    }
    /// <summary>
    /// The CallBackTest class has a LongRunning method which is a forloop
    /// </summary>
    public class CallBackTest 
    {
        public delegate void CallBack(int i); // the degate CallBack gives updates about the LongRunning method
        public void LongRunning(CallBack obj)
        {
            for (int i = 0; i < 5000; i++)
            {
                Console.WriteLine("I am looping");
                obj(i);
            }
        }
    }
}
