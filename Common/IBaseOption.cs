using System;
using System.Collections.Generic;

namespace Common {
    public enum JobType {
        FireAndForget,
        Scheduled,
        Recurring
    }
    public enum RunType {
        Sync,
        Async
    }
    public interface IBaseOption {
        string UserId { get; set; }
        string HfJobId { get; set; }
        TimeZoneInfo TimeZone { get; set; }
        long UserTaskId { get; set; }
        JobType JobType { get; set; }
        RunType RunType { get; set; }
        T GetOption<T> (string key);
        void SetOption (string key, object value);
        Dictionary<string, object> BuildObjectDictionary ();
        void InitializeFromDictionary (Dictionary<string, object> options);

    }
}