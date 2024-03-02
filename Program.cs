double num1, num2, result;
char operation;
System.Console.WriteLine("Kalkulyatorga xush kelibsiz!");
System.Console.WriteLine("Istalgan operatorni tanlang (+, -, /, *):");
operation = Convert.ToChar(Console.ReadLine());

System.Console.WriteLine("Ikkita sonni kiriting:");
num1 = Convert.ToDouble(Console.ReadLine());
num2 = Convert.ToDouble(Console.ReadLine());

switch (operation)
{
    case '+':
    result = num1 + num2;
    System.Console.WriteLine("Natija: " + result);
    break;

    case '-':
    result = num1 - num2;
    System.Console.WriteLine("Natija: " + result);
    break;

    case '/':
    if(num2 != 0)
    {
    result = num1 / num2;
    System.Console.WriteLine("Natija: " + result);
    }
    else
    {
        System.Console.WriteLine("Nolga bo'lish mumkin emas!");
    }
    break;

    case '*':
    result = num1 * num2;
    System.Console.WriteLine("Natija: " + result);
    break;

}
