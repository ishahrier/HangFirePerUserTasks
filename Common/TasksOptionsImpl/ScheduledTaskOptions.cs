using System;

namespace Exico.HangFire.Common {
    public class ScheduledTaskOptions : ABaseOptions, IScheduledTaskOptions {

        public ScheduledTaskOptions():base()
        {
            JobType = Exico.HangFire.Common.JobType.Scheduled;
        }

        public TimeSpan ScheduledAt {
            get => GetOption<TimeSpan>("ScheduledAt");
            set => SetOption("ScheduledAt", value);
        }
    }
}