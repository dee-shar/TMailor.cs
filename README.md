# TMailor.cs
Web-API for [tmailor.com](https://tmailor.com) the most advanced Disposable Temporary Email service that helps you avoid spam and stay safe

## Example
```cs
using TMailorApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new TMailor();
            string email = await api.GenerateEmail();
            Console.WriteLine(email);
        }
    }
}
```
