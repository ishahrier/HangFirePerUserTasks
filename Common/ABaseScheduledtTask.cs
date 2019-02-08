using Hangfire;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exico.HangFire.Common
{
    public abstract class ABaseScheduledtTask : ABaseTask
    {
        public ABaseScheduledtTask(IScheduledTaskOptions options):base(options)
        {
             
        }
    }
}