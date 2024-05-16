
using SimpleCalculator.Classes;

Security security = new Security();
Calculator calculator = new Calculator();

security.CheckPassword();

calculator.GetInputs();

string message =
    !(calculator.IsFirstNumberPositive())
       ? "1st number is not positive"
       : "2nd number is not positive";
Console.WriteLine(message);

calculator.CompareInputs();

string result = (calculator.Calculate());
Console.WriteLine(result);

calculator.PrintEvenNumbers();

calculator.PrintMultiplicationTable();