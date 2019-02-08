using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hangfire;

namespace Exico.HangFire.Common
{
    public class MyFireAndForgetTask : ABaseFireAndForgetTask
    {
        public override void UpdateTaskStatus()
        {
            Console.WriteLine("updated status");
        }

        public override async Task Run(string jsonOptionsString, IJobCancellationToken cancellationToken)
        {
             await base.Run(jsonOptionsString, cancellationToken);
            Console.WriteLine("Ran task in " + this.GetType().AssemblyQualifiedName);
            Console.WriteLine("Job Type is  " + this._Options.JobType);
            Console.WriteLine("For user  " + this._Options.UserId);
        }
    }
}
