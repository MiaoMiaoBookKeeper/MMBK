using MMBK.Core.Contract;
using MMBK.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBK.Service
{
    public class DemoService : IDemoService
    {
        public DemoService()
        {
                
        }

        public async Task<int> GetAsync()
        {
            return 19;
        }

        public async Task<int> AddAsync(int input)
        {
            return (input + 1);
        }

        public async Task RunAsync()
        {
            Console.WriteLine("Demo Runs....");
            
        }
    }
}
