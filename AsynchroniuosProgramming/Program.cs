using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AsynchroniuosProgramming
{
    class Program
    {
         static void Main(string[] args)
        {
            //in .net 4.5 there is a new framework for async programming

            //var html = await GetHtmlAsync(@"http://msdn.microsoft.com");
        }

        //Task encapsulate the state of asynchronius object
        public async Task DownloadHtmlAsync(string url) //Task without parenthesis when return type is void
        {
            var weclient = new WebClient();
            var html = await weclient.DownloadStringTaskAsync(url); //await returns conytol to caller method

            using (var streamWriter = new StreamWriter(@"C://text.txt"))
            {
               await streamWriter.WriteAsync(html);
            }
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);             
        }
    }
}
