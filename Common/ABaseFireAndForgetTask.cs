using Hangfire;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exico.HangFire.Common
{
    public abstract class ABaseFireAndForgetTask : ABaseTask,IFireAndForgetTask
    {
        public ABaseFireAndForgetTask(IFireAndForgetTaskOptions options):base(options)
        {
             
        }
    }
}