using System.Diagnostics;
using System.Text;
#region  problem 1


Stopwatch stopwatch = Stopwatch.StartNew();
System.Console.WriteLine("Problem 1:");
    string production = "";
for (int  i = 0;  i < 5000;  i++)
{
    production += "Prod" +i+ "\n";
}

stopwatch.Stop();
// it will take a lot of time to execute and it will take alot of memory because it's creating a new string every time and it will create a lot of garbage in the memory 

    System.Console.WriteLine(stopwatch);


// solve

Stopwatch stopwatch2 = Stopwatch.StartNew();
    System.Console.WriteLine("Problem 1 Solved:");
    StringBuilder production2 = new StringBuilder();
for (int  i = 0;  i < 5000; i++)
{
    production2.Append("Prod" +i+ "\n");
}


stopwatch2.Stop();
    System.Console.WriteLine(stopwatch2);       

#endregion