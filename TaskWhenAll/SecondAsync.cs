using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWhenAll
{
    public class SecondAsync
    {
        public async Task SecondMethodAsync()
        {
            for (int i = 0; i < 10; i++) { 
            await Task.Delay(1000);
            Console.WriteLine("Second");
            }
        }
    }
}
