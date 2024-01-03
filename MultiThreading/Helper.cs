namespace util;
using System.Threading;

public static class Helper{
    public static async Task StoreData(){
        await Task.Run(()=>{
            Console.WriteLine("Task data");
        });
    }
    public static async Task RetriveData(){
        await Task.Run(()=>{
            Console.WriteLine("Retrive data");
        });
    }
}