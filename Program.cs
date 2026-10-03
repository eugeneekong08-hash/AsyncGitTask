using System;
using System.Diagnostics;
using System.Threading.Tasks;

async Task<string> GetUserAsync()
{
    await Task.Delay(2000);
    return "User loaded";
}

async Task<string> GetOrdersAsync()
{
    await Task.Delay(2000);
    return "Orders loaded";
}

async Task<string> GetMessagesAsync()
{
    await Task.Delay(2000);
    return "Messages loaded";
}

Stopwatch stopwatchA = new Stopwatch();
stopwatchA.Start();

string userResult = await GetUserAsync();
string ordersResult = await GetOrdersAsync();
string messagesResult = await GetMessagesAsync();

Console.WriteLine(userResult);
Console.WriteLine(ordersResult);
Console.WriteLine(messagesResult);

stopwatchA.Stop();
Console.WriteLine("Task A total time: " + stopwatchA.Elapsed.TotalSeconds + " seconds");