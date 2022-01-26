using System;
using System.Collections;
Console.WriteLine("Hello, what kind of operation would you like to use? \n1.Addition \n2.Subtraction\n3.Multiplication\n4.Division\n5.Fahrenheit To Celsius\n6.Celsius to Fahrentheit\n7.Celsius to Kelvin\nAny other input to Quit");
int choice = int.Parse(Console.ReadLine());
switch(choice)
{ 
    case  1:
    Adding();
break;
    case  2:
    Subtraction();
break;
    case  3:
    Multiplication();
break;
    case  4:
    Division();
break;
    case 5:
    FahrenheitToCelsius();
break;
    case 6:
        CelsiusToFahrenheit();
break;
    case 7:
        CelsiusToKelvin();
break;

}


static void Adding()
{
    Stack<float> add1 = new Stack<float>();
    Stack<float> add2 = new Stack<float>();
    Console.WriteLine("Input items you want to add. To stop adding items press 999");
    float addInput = 0;
    while (addInput != 999)
    { 
        addInput = float.Parse(Console.ReadLine());
        if (addInput != 999)
        {
            add1.Push(addInput);
        }
    }
    float addingamount = 0;
    while(add1.Count() != 0)
    {
        addingamount = add1.Pop() + addingamount;
    }
    Console.WriteLine("Your toal is: "+ addingamount);
}
static void Subtraction()
{ 
    Stack<decimal> sub1 = new Stack<decimal>();
    Stack<decimal> sub2 = new Stack<decimal>();
    Console.WriteLine("Input items you want to subtract. To stop subtracting press 999");
    decimal subInput = 0;
    while (subInput != 999)
    {
        subInput = decimal.Parse(Console.ReadLine());
        if (subInput != 999)
        {
            sub1.Push(subInput);
        }
    }
    decimal subingamount = 0;

    while (sub1.Count() != 0)
    {
        sub2.Push(sub1.Pop());
    }
    int popnumber = sub2.Count();
    while (sub2.Count() != 0)
    {
        if (popnumber == sub2.Count())
        {
            subingamount = sub2.Pop();
        }
        else
        { 
            subingamount = subingamount - sub2.Pop();
        }
    
    }
    Console.WriteLine("Your total is: " + subingamount);
}
static void Multiplication()
{
    Stack<decimal> multi1 = new Stack<decimal>();
    Stack<decimal> multi2 = new Stack<decimal>();
    Console.WriteLine("Input items you want to multiply. To stop subtracting press 999");
    decimal multiInput = 0;
    while (multiInput != 999)
    {
        multiInput = decimal.Parse(Console.ReadLine());
        if (multiInput != 999)
        {
            multi1.Push(multiInput);
        }
    }
    decimal multiamount = 0;

    while (multi1.Count() != 0)
    {
        multi2.Push(multi1.Pop());
    }
    int popnumber = multi2.Count();
    while (multi2.Count() != 0)
    {
        if (popnumber == multi2.Count())
        {
            multiamount = multi2.Pop();
        }
        else
        {
            multiamount = multiamount * multi2.Pop();
        }

    }
    Console.WriteLine("Your total is: " + multiamount);
}
static void Division()
{
    Stack<decimal> div1 = new Stack<decimal>();
    Stack<decimal> div2 = new Stack<decimal>();
    Console.WriteLine("Input items you want to divide. To stop subtracting press 999");
    decimal divInput = 0;
    while (divInput != 999)
    {
        divInput = decimal.Parse(Console.ReadLine());
        if (divInput != 999)
        {
            div1.Push(divInput);
        }
    }
    decimal divamount = 0;

    while (div1.Count() != 0)
    {
        div2.Push(div1.Pop());
    }
    int popnumber = div2.Count();
    while (div2.Count() != 0)
    {
        if (popnumber == div2.Count())
        {
            divamount = div2.Pop();
        }
        else
        {
            divamount = divamount / div2.Pop();
        }

    }
    Console.WriteLine("Your total is: " + divamount);
}
static void FahrenheitToCelsius()
{
    Console.WriteLine("What degree in Fahrenheit to you want to convert to Celsius?");
    decimal fahConver = decimal.Parse(Console.ReadLine());
    decimal conversion = (fahConver - 32)*5/9;
    Console.WriteLine("The conversion is: "+ conversion);

}
static void CelsiusToFahrenheit()
{
    Console.WriteLine("What degree in Celsius to you want to convert to Fahrenheit?");
    decimal celConver = decimal.Parse(Console.ReadLine());
    decimal conversion = (celConver * 9/5) + 32;
    Console.WriteLine("The conversion is: " + conversion);
}
static void CelsiusToKelvin()
{
    Console.WriteLine("What degree in Celsius to you want to convert to Kelvin?");
    double celConver = double.Parse(Console.ReadLine());
    double conversion = celConver + 273.15;
    Console.WriteLine("The conversion is: " + conversion);
}
