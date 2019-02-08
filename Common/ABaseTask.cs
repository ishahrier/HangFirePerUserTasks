using Hangfire;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exico.HangFire.Common
{
    public abstract class ABaseFireAndForgetTask : IFireAndForgetTask
    {
        public ABaseFireAndForgetTask(IFireAndForgetOptions options)
        {
            this._Options = options;
        }
        protected IFireAndForgetOptions _Options { get; set; }
        public virtual async Task Run(string jsonOptions, IJobCancellationToken cancellationToken) => await Task.Run(() => InitiaLizeOption(jsonOptions));
        protected void InitiaLizeOption(string jsonOptoins)
        {
            var setting = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            _Options.InitializeFromDictionary(JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonOptoins, setting));
        }

        public abstract void UpdateTaskStatus();
    }
}