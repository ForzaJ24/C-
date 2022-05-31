// Max and Min numbers

Console.WriteLine("Hi,Mentor!Please,enter first number: ");

int a = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Please,enter second number: ");

int b = Convert.ToInt32(Console.ReadLine());


if (a < b) 
{ 
    Console.WriteLine("Min = ");
    Console.WriteLine(a);
    Console.WriteLine("Max = ");
    Console.WriteLine(b);

 }
else if (a > b) 
{
     Console.WriteLine("Min = ");
    Console.WriteLine(b);
    Console.WriteLine("Max = ");
    Console.WriteLine(a);
}
else if (a == b) 
{ 
    Console.WriteLine("Its same numbers");
 }