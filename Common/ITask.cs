using Hangfire;

namespace Common {
    public interface ITask {
        void Run (string jsonOptionsString, IJobCancellationToken cancellationToken);
    }
}