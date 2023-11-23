using MMBK.Core.Model;
using System.Threading.Tasks;

namespace MMBK.Core.Contract
{
    public interface IDemoService
    {
        Task<int> GetAsync();
        Task<int> AddAsync(int input);
        Task RunAsync();
    }
}