using System;

namespace Exico.HangFire.Common {
    public interface IScheduledTaskOptions : IBaseTaskOptions {

        TimeSpan ScheduledAt { get; set; }
    }
}