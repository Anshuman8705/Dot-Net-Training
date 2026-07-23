// Lambda Function - shorter way to write anonymous Function 
// (parameters) => expression 

Func<int, int> square = x => x * x;
Console.WriteLine(square(6));
Func<int,int,int> subb = (a,b) => a-b;
Console.WriteLine(subb(10,50));

// without Lambda 

void sub(int a ,int b)
{
    int res = a-b;
    Console.WriteLine(res);
}
sub(50,20);