using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hangfire;

namespace Exico.HangFire.Common
{
    public class MyFireAndForgetTask : ABaseFireAndForgetTask
    {
        public MyFireAndForgetTask(IFireAndForgetOptions options) : base(options) { }

        public override void UpdateTaskStatus() => Console.WriteLine("updated status");

        public override async Task Run(string jsonOptionsString, IJobCancellationToken cancellationToken)
        {
            await base.Run(jsonOptionsString, cancellationToken);
            Console.WriteLine("Ran task in " + this.GetType().AssemblyQualifiedName);
            Console.WriteLine("Job Type is  " + this._Options.JobType);
            Console.WriteLine("For user  " + this._Options.GetOption<Temp>("Person").Name);
            Console.WriteLine("User Age" + this._Options.GetOption<Temp>("Person").age);
        }
    }
    public class Temp
    {
        public string Name { get; set; }
        public int age { get; set; }
    }
}
