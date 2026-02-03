// this is variables
int a=2;

if (a % 2 == 0)
{
    Console.WriteLine($"{a} is even");
}
else
{
    Console.WriteLine($"{a} is odd");
}



Console.WriteLine("this is 2nd problem:");




// IMPLEMENTED THE LOGIC OF CHECKING EVEN OR ODD IN REUSABLE FUNCTION FORMAT
static bool iseven(int a)
{
    return a % 2 == 0;
}



int b=(5);
// Console.WriteLine(iseven($"{2} is even")); #this is a mistake i made at first
if (iseven(b))
{
    Console.WriteLine($"{b} is even");
}
else
{
    Console.WriteLine($"{b} is odd");
}