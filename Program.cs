double num1, num2, result;
char operation;
string DavomEt;
Salom:
System.Console.WriteLine("Kalkulyatorga xush kelibsiz!");
System.Console.Write("Birinchi sonni kiriting: ");
num1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Operator kiriting: ");
operation = Convert.ToChar(Console.ReadLine());

System.Console.Write("Ikkinchi sonni kiriting: ");
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
System.Console.WriteLine("Davom etasizmi!");
DavomEt = Console.ReadLine();
if(DavomEt == "yes")
{
    goto Salom;
}
else if(DavomEt == "NO")
{
    System.Console.WriteLine("Goodbay");
    
}
