using Hangfire;
namespace Exico.HangFire.Common {
    public class JobManager {
        public void CreateFireAndForgetJob (IFireAndForgetOptions options, IBackgroundJobClient hfClient) {
            hfClient.Enqueue<IFireAndForgetTask> (x => x.Run (options.ToJson (), JobCancellationToken.Null));
        }
    }
}

//TODO now i have to create a database , enter the record there before creating a task