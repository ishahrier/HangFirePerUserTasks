using Hangfire;
namespace Common {
    public class JobManager {
        public void CreateFireAndForgetJob (IFireAndForgetOptions options, IBackgroundJobClient hfClient) {
            hfClient.Enqueue<IFireAndForgetTask> (x => x.Run (options.ToJson (), JobCancellationToken.Null));
        }
    }
}