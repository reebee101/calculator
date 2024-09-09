using System.Numerics;

class operations
{    public int plus(int x, int y){return x + y;}
    public int minus(int x, int y) { return x-y; }
    public int multiply(int x, int y) { return x * y; }
    public int divide(int x, int y) {
        if (y==0)
            throw new DivideByZeroException("cant divide by zero");
        return x / y; }         }
class program
{
    static void Main(string[] args)
    {
        operations operations=new operations();

        Console.WriteLine("choose an operator (+,-,*,/)");
        string op= Console.ReadLine();
        Console.WriteLine("enter first number");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("enter second number");
        int y = int.Parse(Console.ReadLine());

        int res = 0;
        bool valop=true;

        switch (op)
            {
            case "+":
                 res= operations.plus(x, y);
                break;

            case "-": 
                res= operations.minus(x,y); 
                break;

            case "*":
                res = operations.multiply(x, y);
                break;

            case "/":
                try { res = operations.divide(x, y); }
                catch (DivideByZeroException e)
                { Console.WriteLine(e.Message);
                    valop = false;
                }
                break;
            dafault:
                Console.WriteLine("invalid op");
                valop=false;
        }
        if (valop) { Console.WriteLine($"result={res}"); }


    }
}
