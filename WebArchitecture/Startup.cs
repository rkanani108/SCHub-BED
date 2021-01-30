using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StackExchange.Redis;
using Web.Middleware;
using Web.Services;
using Web.Services.Model;
using Web.Services.Services;
using WebMarkupMin.AspNetCore3;

namespace Web
{
    public class Startup
    {
        public static IConfiguration StaticConfig { get; private set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            StaticConfig = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddSingleton<ISquindexService, SquindexService>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<ITempleService, TempleService>();
            services.AddDetection();

            services.AddDistributedRedisCache(option =>
            {
                option.Configuration = "redis-11846.c56.east-us.azure.cloud.redislabs.com:11846";
                option.InstanceName = "tej-web-us";
                option.ConfigurationOptions = new ConfigurationOptions()
                {
                    EndPoints = { "redis-11846.c56.east-us.azure.cloud.redislabs.com:11846" },
                    Password = "ArwpjNmiDqdeYckDlkoEDZLtyFOzlRQy"
                };
            });
            services.AddControllers();
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddWebMarkupMin(

        options =>
        {
            options.AllowMinificationInDevelopmentEnvironment = true;
            options.AllowCompressionInDevelopmentEnvironment = true;
        })
        .AddHtmlMinification(
            options =>
            {
                options.MinificationSettings.RemoveRedundantAttributes = true;
                options.MinificationSettings.RemoveHttpProtocolFromAttributes = true;
                options.MinificationSettings.RemoveHttpsProtocolFromAttributes = true;
            }).AddHttpCompression();
            services.AddHttpContextAccessor();
            services.Configure<SquindexSettings>(Configuration.GetSection("SquindexSettings"));

            //services.AddRazorPages().AddRazorPagesOptions(options =>
            //{
            //    options.Conventions.AddPageRoute("/", "{slug:string}");
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseWebMarkupMin();
            app.UseRouting();
            app.UseAuthorization();
            app.UseMiddleware<RedisCacheMiddleware>(); app.UseMiddleware<RedisCacheMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });
            Web.Helper.AppContext.Configure(app.ApplicationServices.GetRequiredService<IHttpContextAccessor>());
        }
    }
}