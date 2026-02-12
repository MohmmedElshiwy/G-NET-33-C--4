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


// #region Problem 2


// System.Console.WriteLine("Problem 2:");

// double price =0.0;
// double BasePrice =0;
// double Discount =0;
// double weekendExtra=0;

// System.Console.WriteLine("Enter Your Age:");
// int Age;
// while (!int.TryParse(Console.ReadLine(), out Age))
// {
//     System.Console.WriteLine("Invalid input. Please enter a valid age:");
// }
// if (Age < 5)
// {
//     System.Console.WriteLine($"Price is Free");
//     // return;
// }else if (Age >= 5 && Age <= 12)
// {
//     BasePrice = 30;
//     System.Console.WriteLine($"Base Price: {BasePrice}");
// }
// else if (Age > 12 && Age <= 59)
// {
//     BasePrice = 50;
//     System.Console.WriteLine($"Base Price: {BasePrice}");
// }
// else
// {
//     BasePrice = 25;
//     System.Console.WriteLine($"Base Price: {BasePrice}");
// }
// price= BasePrice;

// System.Console.WriteLine("Enter The Numeber Of Days:");

// System.Console.WriteLine($@"1.sunday
// 2.monday
// 3.tuesday
// 4.wednesday
// 5.thursday
// 6.friday
// 7.saturday");
// int day;
// while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
// {
//     System.Console.WriteLine("Invalid input. Please enter a valid day number (1-7):");
// }
// if(price >0 && (day==6||day == 7))
// {
    
//     weekendExtra =10;
//     price = price + weekendExtra;
// }

// if(price >0 ){
// System.Console.WriteLine("Are you Student? (yes/no)");
// string isStudent = Console.ReadLine().Trim().ToLower();
// if (isStudent == "y" ||isStudent=="yes" && price > 0)
// {
    
//     Discount = price * 0.20;
//     price = price - Discount;
// }
// }



// System.Console.WriteLine($"The Main Price: {BasePrice}");
// System.Console.WriteLine($"The Weekend Extra: {weekendExtra}");
// System.Console.WriteLine($"The Discount: {Discount}");
// System.Console.WriteLine($"The Final Price: {price}");

// #endregion


// #region Problem 3

// System.Console.WriteLine("Problem 3:");

// string FileExtension = ".jpg";
// string FileType ;

// switch (FileExtension.ToLower())

// {
//     case "pdf":
//     FileType ="PDF Document";
//     break;
//     case ".docx":
//     case ".doc":
//     FileType ="Word Document";
//     break;
//     case ".xlsx":
//     case ".xls":
//     FileType ="Excel Spreadsheet";
//     break;
//     case ".jpg":
//     case ".png":
//     case ".gif":
//     FileType ="Image File";
//     break;
//     default:
//     FileType ="Unknown File Type";
//     break;

// }



// string FileExtension = ".jpg";
// string FileType = FileExtension switch 
//     {
//         ".pdf" => "PDF Document",
//         ".docx" or ".doc" => "Word Document",
//         ".xlsx" or ".xls" => "Excel Spreadsheet",
//         ".jpg" or ".png" or ".gif" => "Image File",
//         _ => "Unknown File Type"
    
//     };

// System.Console.WriteLine($"The File Type is: {FileType}");


    
// #endregion

// #region Problem 4
    
//     Console.WriteLine("Problem 4:");
    
//     int temperature = 0;
//     string weatherAdvice = temperature <0 ? "Freezing ! Stay indoor " 
//     : temperature <15 ? "Cold ! Wear a jacket" 
//     : temperature <25 ? "Pleasant weather" 
//     :temperature  <35 ? "Warm . Stay hydrated"
//     :"Hot ! Avoid Sun Exposure";

//     System.Console.WriteLine($"Weather Advice: {weatherAdvice}");

//     // the ternary operator in this case is not the best choise beacuse it can be hard to read and understand 
//     // the ternary operator could be used for less than 2 conditions, 
// #endregion

// #region  Problem 5

// System.Console.WriteLine("Problem 5:");

// int level = 0;
// int maxLevel = 5;
// bool IsValid = false;

// do
// {
//    System.Console.WriteLine("Enter your password:");
   
//    string password = Console.ReadLine().Trim();
//    bool Upper =false;
// bool Degit =false;
// bool Space =false;

//    foreach(char c in password)
//     {
//         if (char.IsUpper(c))
//         {
//             Upper = true;
//         }
//         else if (char.IsDigit(c))
//         {
//             Degit =true;
//         }
//         else if (char.IsWhiteSpace(c))
//         {
//             Space = true;
//         }

//     } 
//                 Console.WriteLine("---- Validation Result ----");
//     if (password.Length < 8)
//     {
//         System.Console.WriteLine("Password Length: Invalid (Less than 8 characters)");
//     }
//     if (!Upper)
//     {
//         System.Console.WriteLine("Password must contain at least one uppercase letter.");
//     }
//     if (!Degit)    {
//         System.Console.WriteLine("Password must contain at least one digit.");
//     }
//     if (Space)    {
//         System.Console.WriteLine("Password must not contain spaces.");
//     }
//     IsValid = password.Length>=8 && Upper && Degit && !Space;
//     if (IsValid)    {
//         System.Console.WriteLine("Password is valid.");
//         break;
//     }
//     level++;
//     if (level == maxLevel)
//             {
//                 Console.WriteLine("🚫 Account locked.");
//             }
//             else
//             {
//                 Console.WriteLine($"Attempts left: {maxLevel - level}");
//                 Console.WriteLine();
//             }
// }while (level < maxLevel);
// #endregion


#region problem 6

System.Console.WriteLine("Problem 6:");

int [] scores = { 85, 91, 67, 55, 78,39,88,72,95,60,48 };

int i = 0;

while(i < scores.Length)
{
    if (scores[i] <= 50)
    {
        System.Console.WriteLine($"Score {scores[i]} is below 50.");
    }
    i++;
}
    Console.WriteLine("First score above 90:");
int j =0;
while (j < scores.Length)
{
    if (scores[j] >= 90)
    {
        System.Console.WriteLine($"Score {scores[j]} is above 90.");
        break;
    }
    j++;
}


System.Console.WriteLine("Avg score abouve 40");

int sum = 0;
int count = 0;
while (count < scores.Length)
{
    if (scores[count] > 40)
    {
        sum += scores[count];
    }
    count++;
}
double Avg = count > 0 ? sum / count : 0;
System.Console.WriteLine($"The Average Score above 40 is: {Avg}");

int a =0,b=0,c=0,d=0,f =0;
int k=0;
while (k < scores.Length)
{
    if(scores[k]>=90)
    a++;
    else if (scores[k]>=80)
    b++;
    else if (scores[k]>=70)
    c++;
    else if (scores[k]>=60)
    d++;
    else f++;
    k++;
}
System.Console.WriteLine($"Number of scores above 90: {a}");
System.Console.WriteLine($"Number of scores between 80 and 89: {b}");
System.Console.WriteLine($"Number of scores between 70 and 79: {c}");
System.Console.WriteLine($"Number of scores between 60 and 69: {d}");
System.Console.WriteLine($"Number of scores below 60: {f}");
#endregion