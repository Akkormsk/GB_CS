// Task_1

Console.WriteLine("Task1:_______________");
Console.Write("Input a: ");
int a_1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Input b: ");
int b_1 = Convert.ToInt16(Console.ReadLine());

if (a_1 > b_1)
{
    Console.WriteLine("Max = " + a_1);
}
else
{
    Console.WriteLine("Max = " + b_1);
}

// Task_2

Console.WriteLine("Task2:_______________");
Console.Write("Input a: ");
int a_2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Input b: ");
int b_2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Input c: ");
int c_2 = Convert.ToInt16(Console.ReadLine());

if (a_2 > b_2 && a_2 > c_2)
{
    Console.WriteLine("Max = " + a_2);
}
else if (b_2 > a_2 && b_2 > c_2)
{
    Console.WriteLine("Max = " + b_2);
}
else if (c_2 > b_2 && c_2 > a_2)
{
    Console.WriteLine("Max = " + c_2);
}
else
{
    Console.WriteLine("There is no biigest num (or more then one)");
}

// Task_3

Console.WriteLine("Task3:_______________");
Console.Write("Input a: ");
int a_3 = Convert.ToInt16(Console.ReadLine());
if (a_3 % 2 == 0)
{
    Console.WriteLine("True, it's even");
}
else
{
    Console.WriteLine("No, it's odd");
}

// Task_4

Console.WriteLine("Task4:_______________");
Console.Write("Input N: ");
int n = Convert.ToInt16(Console.ReadLine());
for (int i = 2; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}