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
            _ = Task.CompletedTask;
            return 0;
        }

        public async Task<int> AddAsync(int input)
        {
            _ = Task.CompletedTask;
            return input++;
        }

        public async Task RunAsync()
        {
            _ = Task.CompletedTask;
            Console.WriteLine("Demo Runs....");
            
        }
    }
}
