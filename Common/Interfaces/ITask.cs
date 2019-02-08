using Hangfire;
using System.Threading.Tasks;

namespace Common {
    public interface ITask {
        Task Run (string jsonOptionsString, IJobCancellationToken cancellationToken);

    }
}