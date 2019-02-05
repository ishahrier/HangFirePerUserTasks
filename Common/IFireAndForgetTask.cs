using Hangfire;

namespace Common {
    public interface IFireAndForgetTask : ITask {
        void UpdateTaskStatus ();

    }
}