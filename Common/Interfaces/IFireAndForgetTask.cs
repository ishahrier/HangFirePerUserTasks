using Hangfire;

namespace Exico.HangFire.Common {
    public interface IFireAndForgetTask : ITask {
        void UpdateTaskStatus ();

    }
}