namespace Exico.HangFire.Common {
    public class FireAndForgetOptions : ABaseOptions, IFireAndForgetOptions {

        public FireAndForgetOptions():base()
        {
            JobType = Exico.HangFire.Common.JobType.FireAndForget;
        }
    }
}