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

async Task<string> GetPaymentsAsync()
{
    await Task.Delay(1000);
    throw new InvalidOperationException("Payment service unavailable");
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

Stopwatch stopwatchB = new Stopwatch();
stopwatchB.Start();

Task<string> userTask = GetUserAsync();
Task<string> ordersTask = GetOrdersAsync();
Task<string> messagesTask = GetMessagesAsync();

await Task.WhenAll(userTask, ordersTask, messagesTask);

Console.WriteLine(await userTask);
Console.WriteLine(await ordersTask);
Console.WriteLine(await messagesTask);

stopwatchB.Stop();
Console.WriteLine("Task B total time: " + stopwatchB.Elapsed.TotalSeconds + " seconds");

double timeDifference = stopwatchA.Elapsed.TotalSeconds - stopwatchB.Elapsed.TotalSeconds;
Console.WriteLine("Time difference between Task A and Task B: " + timeDifference + " seconds");

try
{
    string paymentsResult = await GetPaymentsAsync();
    Console.WriteLine(paymentsResult);
}
catch (Exception ex)
{
    Console.WriteLine("Payments could not be processed right now. Please try again later.");
}