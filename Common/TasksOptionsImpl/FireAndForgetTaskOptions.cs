namespace Exico.HangFire.Common {
    public class FireAndForgetTaskOptions : ABaseOptions, IFireAndForgetTaskOptions {

        public FireAndForgetTaskOptions():base()
        {
            JobType = Exico.HangFire.Common.JobType.FireAndForget;
        }
    }
}