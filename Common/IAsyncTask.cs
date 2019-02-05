using System.Threading.Tasks;
using Hangfire;

namespace Common {
    public interface IAsyncTask {
        Task RunAsync (string jsonOptionsString, IJobCancellationToken cancellationToken);
    }
}