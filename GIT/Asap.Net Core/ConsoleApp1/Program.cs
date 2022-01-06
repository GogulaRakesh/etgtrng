using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { 

        static void Main(string[] args)
        {
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44354/");
                //HTTP GET
                var responseTask = client.GetAsync("Pizza");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync(); 
                    readTask.Wait(); var students = readTask.Result; 
                     
                     
                        Console.WriteLine(students); 
                    
                }
            }
            Console.ReadLine();


        }
    }
}
