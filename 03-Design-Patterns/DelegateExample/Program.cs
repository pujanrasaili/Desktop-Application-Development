namespace DelegateExample
{
    public class program
    {
        public delegate void MathOperation(int a, int b);
        public static void Main(string[] args)
        
        {
            int number1 = 10;
            int number2 = 25;
            Add(number1, number2);

            //static delegate method
            MathOperation addDelegate = Add;
            MathOperation subtractDelegate = Subtract;
            addDelegate(number1, number2);

            Console.WriteLine("Multicast Delegate started");
            Console.WriteLine();
            //multicast delegate method
            MathOperation multicastDelegates = Add;
            multicastDelegates += Subtract;
            multicastDelegates += Add;  
            
            multicastDelegates(number1, number2);

            Console.WriteLine("Callback started");
            CallBackExample(40, 5, addDelegate);
            CallBackExample(40, 5, subtractDelegate);

        }

        public static void Add(int a, int b)
        {
            Console.WriteLine("The addition of two number is:" + (a + b));
            Console.WriteLine();
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine("The subtraction of two number is" + (a - b));
            Console.WriteLine();
        }

        public static void CallBackExample(int a, int b, MathOperation mathoperation)
        {
            mathoperation(a, b);
        }

    }
}