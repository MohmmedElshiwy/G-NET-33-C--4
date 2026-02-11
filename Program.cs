using System.Runtime.Intrinsics.Arm;
using System.Diagnostics;

using System.Text;
// #region  problem 1


// Stopwatch stopwatch = Stopwatch.StartNew();
// System.Console.WriteLine("Problem 1:");
//     string production = "";
// for (int  i = 0;  i < 5000;  i++)
// {
//     production += "Prod" +i+ "\n";
// }

// stopwatch.Stop();
// // it will take a lot of time to execute and it will take alot of memory because it's creating a new string every time and it will create a lot of garbage in the memory 

//     System.Console.WriteLine(stopwatch);


// // solve

// Stopwatch stopwatch2 = Stopwatch.StartNew();
//     System.Console.WriteLine("Problem 1 Solved:");
//     StringBuilder production2 = new StringBuilder();
// for (int  i = 0;  i < 5000; i++)
// {
//     production2.Append("Prod" +i+ "\n");
// }


// stopwatch2.Stop();
//     System.Console.WriteLine(stopwatch2);       

// #endregion


#region Problem 2


System.Console.WriteLine("Problem 2:");

double price =0.0;
double BasePrice =0;
double Discount =0;
double weekendExtra=0;

System.Console.WriteLine("Enter Your Age:");
int Age;
while (!int.TryParse(Console.ReadLine(), out Age))
{
    System.Console.WriteLine("Invalid input. Please enter a valid age:");
}
if (Age < 5)
{
    System.Console.WriteLine($"Price is Free");
    // return;
}else if (Age >= 5 && Age <= 12)
{
    BasePrice = 30;
    System.Console.WriteLine($"Base Price: {BasePrice}");
}
else if (Age > 12 && Age <= 59)
{
    BasePrice = 50;
    System.Console.WriteLine($"Base Price: {BasePrice}");
}
else
{
    BasePrice = 25;
    System.Console.WriteLine($"Base Price: {BasePrice}");
}
price= BasePrice;

System.Console.WriteLine("Enter The Numeber Of Days:");

System.Console.WriteLine($@"1.sunday
2.monday
3.tuesday
4.wednesday
5.thursday
6.friday
7.saturday");
int day;
while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
{
    System.Console.WriteLine("Invalid input. Please enter a valid day number (1-7):");
}
if(price >0 && (day==6||day == 7))
{
    
    weekendExtra =10;
    price = price + weekendExtra;
}

if(price >25){
System.Console.WriteLine("Are you Student? (yes/no)");
string isStudent = Console.ReadLine().Trim().ToLower();
if (isStudent == "y" ||isStudent=="yes" && price > 0)
{
    
    Discount = price * 0.20;
    price = price - Discount;
}
}



System.Console.WriteLine($"The Main Price: {BasePrice}");
System.Console.WriteLine($"The Weekend Extra: {weekendExtra}");
System.Console.WriteLine($"The Discount: {Discount}");
System.Console.WriteLine($"The Final Price: {price}");

#endregion