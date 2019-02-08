using Hangfire;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Exico.HangFire.Common
{
    public abstract class ABaseFireAndForgetTask : IFireAndForgetTask
    {
        protected IFireAndForgetOptions _Options { get; set; }
        public virtual async Task Run(string jsonOptionsString, IJobCancellationToken cancellationToken) => await Task.Run(() => InitiaLizeOption(jsonOptionsString));
        protected void InitiaLizeOption(string jsonOptionsString) => _Options = JsonConvert.DeserializeObject<IFireAndForgetOptions>(jsonOptionsString);
        public abstract void UpdateTaskStatus();
    }
}
