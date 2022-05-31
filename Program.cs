// Max and Min numbers

Console.WriteLine("Hi,Mentor!Please,enter first number: ");

int a = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Please,enter second number: ");

int b = Convert.ToInt32(Console.ReadLine());


if (a < b) 
{ 
    Console.WriteLine("a=Min b=Max");
 }
else if (a > b) 
{
     Console.WriteLine("a=Max b=Min"); 
}
else if (a == b) 
{ 
    Console.WriteLine("Its same numbers");
 }