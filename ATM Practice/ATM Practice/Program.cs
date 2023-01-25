// See https://aka.ms/new-console-template for more information

int myPin, inPin;
double balance, value1, deposit, wDraw, value2, value3;
Console.WriteLine("Please input pin");
inPin=Convert.ToInt32(Console.ReadLine());
myPin = 1202;
balance = 10000;
if (inPin == myPin)
{
    Console.WriteLine("Your pin is correct");

    Console.WriteLine("Please select an option:");
    Console.WriteLine("(1)Balance check");
    Console.WriteLine("(2)Deposit");
    Console.WriteLine("(3)Withdrawal");
    Console.WriteLine("(4)Change Pin");
    string answer = Console.ReadLine();

    if (answer == "1")
    {
        Console.WriteLine("Your availabale balance is: " + balance);
    }
    if (answer == "2")
    {
        Console.WriteLine("Please enter how much you want to deposit: ");
        value1 = Convert.ToDouble(Console.ReadLine());
        deposit=balance + value1;
        Console.WriteLine("Your current balance is now:" + deposit);
    }

    if (answer == "3")
    {
        Console.WriteLine("Please enter how much you want to withdraw: ");
        value2 = Convert.ToInt32(Console.ReadLine());
        wDraw = balance - value2;
        Console.WriteLine("Your current balance is now:" + wDraw);
    }
    if (answer == "4")
    {
        Console.WriteLine("What will be your new pin?");
        value3 =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your new pin number is: " + value3);
    }

}
else
{
    Console.WriteLine("Your pin is incorrect! You have 2 attempts remaining. Try again.");
}

