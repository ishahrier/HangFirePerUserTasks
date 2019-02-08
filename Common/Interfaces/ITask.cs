using Hangfire;
using System.Threading.Tasks;

namespace Exico.HangFire.Common {
    public interface ITask {
        Task Run (string jsonOptionsString, IJobCancellationToken cancellationToken);

    }
}