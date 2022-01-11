// See https://aka.ms/new-console-template for more information
using LogicalPrograming;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;

Console.WriteLine("Hello, World!");

//FibonacciSeries fibonacciSeries = new FibonacciSeries();
//fibonacciSeries.Series();

//PerfectNumber perfectNumber = new PerfectNumber();
//perfectNumber.Number();

//PrimeNumber primeNumber = new PrimeNumber();
//primeNumber.Prime();

//ReverseNumber reverseNumber = new ReverseNumber();
//reverseNumber.Reverse();

//StopWatch stopWatch = new StopWatch();
//stopWatch.Calculate();

//CouponNumber couponNumber = new CouponNumber();
//couponNumber.Calculation(N);

bool flag = true;
while (flag)
{
    Console.WriteLine("Enter the program number which is to be executed \n 1.Fibonacci Series \n 2.Perfect Number \n 3.Prime Number \n 4.Reverse a Number \n 5.Coupan Number, \n 6.Stopwatch Program, \n 7.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FibonacciSeries fibonacciSeries = new FibonacciSeries();
            fibonacciSeries.Series();
            break;
        case 2:
            PerfectNumber perfectNumber = new PerfectNumber();
            perfectNumber.Number();
            break;
        case 3:
            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.Prime();
            break;
        case 4:
            ReverseNumber reverseNumber = new ReverseNumber();
            reverseNumber.Reverse();
            break;
        case 5:
            Console.Write("How many numbers you wants to generate :");
            int N = Convert.ToInt32(Console.ReadLine());
            CouponNumber couponNumber = new CouponNumber();
            couponNumber.Calculation(N);
            break;
        case 6:
            StopWatch stopWatch = new StopWatch();
            stopWatch.Calculate();
            break;
        case 7:
            flag = false;
            break;
    }
}