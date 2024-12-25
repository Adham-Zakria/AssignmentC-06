namespace AssignmentC_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 1
            ///* the passing by value passes the location of input parameter so 
            //   the var in function stack frame refere to the same location of parameter at heap */

            ///* the passing by reference makes the var in function which the input parameter assigned to
            //   equal the parameter in the main stack from (temporary) and both of them refere to the value in heap */

            //static int SumArray(int[] Arr)
            //{
            //    int Sum = 0;

            //    for (int i = 0; i < Arr.Length; i++)
            //    {
            //        Sum += Arr[i];
            //    }
            //    return Sum;
            //}

            //static int SumArray02(ref int[] Arr)
            //{
            //    int Sum = 0;

            //    for (int i = 0; i < Arr.Length; i++)
            //    {
            //        Sum += Arr[i];
            //    }
            //    return Sum;
            //}

            //int[] test = {10,20,30};

            //SumArray(test);       // passing by value
            //SumArray02(ref test); // passing by reference

            #endregion

            #region Q 2
            //static void SumSub(int a, int b , out int sum , out int sub)
            //{ 
            //     sum= a+b ;
            //     sub= a-b ;              
            //}
            //Console.WriteLine("enter two integers");
            //int a =int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //SumSub(a, b,out int SumRes,out int SubRes);
            //Console.WriteLine($"the summation is : {SumRes}");
            //Console.WriteLine($"the subtraction is : {SubRes}");
            #endregion

            #region Q 3
            //static void MinMaxArray(ref int[] arr)
            //{
            //    int min = arr[0];
            //    int max = arr[0];

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] > max)
            //            max = arr[i];

            //        if (arr[i] < min)
            //            min = arr[i];
            //    }
            //    Console.WriteLine($"the maximum element is {max}");
            //    Console.WriteLine($"the minimum element is {min}");
            //}
            //int[] x = {10,20,30,40,50};
            //MinMaxArray(ref x);
            #endregion
        }
    }
}
