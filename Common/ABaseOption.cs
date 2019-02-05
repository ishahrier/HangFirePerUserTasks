using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Common {
    public abstract class ABaseOption : IBaseOption {
        public Dictionary<string, object> _Options;
        public ABaseOption () => _Options = new Dictionary<string, object> ();

        public string UserId {
            get => GetOption<string> ("UserId");
            set => SetOption ("UserId", value);
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
        public int TaskId {
            get => GetOption<int> ("TaskId");
            set => SetOption ("TaskId", value);
        }

        public Dictionary<string, object> BuildObjectDictionary () => _Options;

        public T GetOption<T> (string key) => _Options.ContainsKey (key) ? (T) (_Options[key]) : default (T);

        public bool HasOption (string key) => _Options.ContainsKey (key);

        public void InitializeFromDictionary (Dictionary<string, object> options) => this._Options = options;
        public void SetOption (string key, object value) => _Options[key] = value;

        public void PrintOptions () {
            string uglyJsonString = JsonConvert.SerializeObject (this._Options);
            string prettyJson = JToken.Parse (uglyJsonString).ToString (Formatting.Indented);
            Console.WriteLine (prettyJson);
        }

        public string ToJson () {
            var setting = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            return JsonConvert.SerializeObject (this._Options, setting);
        }
    }
}