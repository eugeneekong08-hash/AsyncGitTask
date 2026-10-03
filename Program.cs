using System;
using System.Threading.Tasks;


async Task<string> GetUserAsync()
{
    await Task.Delay(2000); // Simulate an asynchronous operation
    return "User loaded";
}

string result = await GetUserAsync();
Console.WriteLine(result);
