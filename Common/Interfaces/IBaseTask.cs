using Hangfire;
using System.Threading.Tasks;

namespace Exico.HangFire.Common {
    public interface IBaseTask {
        Task Run (string jsonOptionsString, IJobCancellationToken cancellationToken);
        void UpdateTaskStatus();

    }
}