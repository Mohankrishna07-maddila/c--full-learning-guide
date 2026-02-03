using System;
vicky 
// just to show a user  a demo
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



int b=(2);
// Console.WriteLine(iseven($"{2} is even")); #this is a mistake i made at first
if (iseven(b))
{
    Console.WriteLine($"{b} is even");
}
else
{
    Console.WriteLine($"{b} is odd");
}



// this is 3rd problem:
static int ramesh(int a)
{
    for (int i=0;i<a;i++)
    {
        return i;
    }
}

int a=3;
if (ramesh(a))
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(a);
}