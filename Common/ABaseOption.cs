using System;
using System.Collections.Generic;
using System.Linq;

namespace Common {
    public abstract class ABaseOption : IBaseOption {
        public Dictionary<string, object> _Options;
        public ABaseOption () => _Options = new Dictionary<string, object> ();

        public string UserId {
            get => GetOption<string> ("UserId");
            set => SetOption ("UserId", value);
        }
        public string HfJobId {
            get => GetOption<string> ("HfJobId");
            set => SetOption ("HfJobId", value);
        }
        public TimeZoneInfo TimeZone {
            get => GetOption<TimeZoneInfo> ("TimeZoneInfo");
            set => SetOption ("TimeZoneInfo", value);
        }
        public long UserTaskId {
            get => GetOption<long> ("UserTaskId");
            set => SetOption ("UserTaskId", value);
        }
        public JobType JobType {
            get => GetOption<JobType> ("JobTYpe");
            set => SetOption ("JobTYpe", value);
        }
        public RunType RunType {
            get => GetOption<RunType> ("RunType");
            set => SetOption ("RunType", value);
        }

        public Dictionary<string, object> BuildObjectDictionary () => _Options;
        public T GetOption<T> (string key) => _Options.ContainsKey (key) ? (T) (_Options[key]) : default (T);
        public void InitializeFromDictionary (Dictionary<string, object> options) => this._Options = options;
        public void SetOption (string key, object value) => _Options[key] = value;
    }
}