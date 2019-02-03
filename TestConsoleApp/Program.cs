using System;
using Common;
namespace TestConsoleApp {
    public class Program {
        static void Main (string[] args) {
            MyOption m = new MyOption ();
            m.UserId = "100";
            m.HfJobId = "job1";

            m.SetOption ("obj", new temp () {
                name = "ROnnie",
                    age = 100
            });
            Console.WriteLine (m.GetOption<temp> ("obj").age);

        }
    }

    public class temp {
        public string name { get; set; }
        public int age { get; set; }
    }
    public class MyOption : ABaseOption {

    }
}