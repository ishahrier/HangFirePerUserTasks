using Exico.HangFire.Common;
using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace TestWebClientServer
{

    public class MyFnFTask : ABaseFireAndForgetTask
    {
        public MyFnFTask(IFireAndForgetTaskOptions options) : base(options)
        {

        }
        public override async Task Run(string jsonOptions, IJobCancellationToken cancellationToken)
        {
            await base.Run(jsonOptions, cancellationToken);
            Console.WriteLine(_Options.GetOption<string>("name"));
        }
        public override void UpdateTaskStatus()
        {

        }
    }
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private void AddRequiredServices(IServiceCollection services)
        {
            services.AddScoped<IFireAndForgetTask, MyFnFTask>();
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            AddRequiredServices(services);
            services.AddHangfire(x => x.UseSqlServerStorage(Configuration.GetConnectionString("HangFireDb")));
            services.AddExicoHfService();
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseHangfireDashboard();
            app.UseHangfireServer();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
