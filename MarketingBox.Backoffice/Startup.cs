using System;
using System.Reflection;
using Autofac;
using MarketingBox.Backoffice.Middlewares;
using MarketingBox.Backoffice.Modules;
using MarketingBox.Backoffice.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MW.Blazor;
using MyJetWallet.Sdk.Service;
using Prometheus;
using SimpleTrading.BaseMetrics;
using SimpleTrading.ServiceStatusReporterConnector;
using Sotsera.Blazor.Toaster.Core.Models;
using Syncfusion.Blazor;

namespace MarketingBox.Backoffice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationInsightsTelemetry(Configuration);
            TagSelectorStyle.Bootstrap.RemoveTagClass = "oi oi-circle-x";

            var settings = Program.Settings;
            
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddHttpContextAccessor();
            services.AddScoped<MyHttpContextAccessor>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
            services.AddAntDesign();

            services.AddToaster(config =>
            {
                config.PositionClass = Defaults.Classes.Position.TopRight;
                config.PreventDuplicates = false;
                config.NewestOnTop = true;
            });

            services.AddHostedService<ApplicationLifetimeManager>();
            
            services.AddMyTelemetry("MB-", Program.Settings.ZipkinUrl);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ApiTraceMiddleware>();
            
            app.BindMetricsMiddleware();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.BindServicesTree(Assembly.GetExecutingAssembly());
            app.BindIsAlive();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapControllers();
                endpoints.MapFallbackToPage("/_Host");
                endpoints.MapMetrics();
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<ServiceModule>();
            //builder.RegisterModule<MyNoSqlModule>();
            builder.RegisterModule<ClientsModule>();
        }
    }
}