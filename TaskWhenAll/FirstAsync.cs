using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWhenAll
{
    public class FirstAsync
    {
        public async Task FirstMethodAsync()
        {
            for (int i = 0; i < 10; i++) { 
            await Task.Delay(1000);
            Console.WriteLine(i);
            }
        }
    }
}
