namespace Refactoring;

public class Fibonacci
{
    public static int Fib(int number)
    {
        int fib = 0;
        for(int i = 1; number == i; i++)
        {
            fib = fib + i;
        }
        if(fib == 0){
            return 1;
        }
        return fib;
    }
}