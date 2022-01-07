using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using identity_poc.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rsk.AspNetCore.Authentication.Saml2p;

namespace identity_poc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();

            services.AddAuthentication()
            .AddCookie("cookie")
            .AddSaml2p("duende", options => {
                options.Licensee = "DEMO";
                options.LicenseKey = "eyJTb2xkRm9yIjowLjAsIktleVByZXNldCI6NiwiU2F2ZUtleSI6ZmFsc2UsIkxlZ2FjeUtleSI6ZmFsc2UsIlJlbmV3YWxTZW50VGltZSI6IjAwMDEtMDEtMDFUMDA6MDA6MDAiLCJhdXRoIjoiREVNTyIsImV4cCI6IjIwMjItMDEtMzBUMDE6MDA6MDAuNDk3MjA0NCswMDowMCIsImlhdCI6IjIwMjEtMTItMzFUMDE6MDA6MDAiLCJvcmciOiJERU1PIiwiYXVkIjoyfQ==.aiYeOa6e18f7YktrlXjl0ROWF7ni0NwbnqrGwww6kZC/OTCARa9yfbew7YAO9vhH4cyTFcr9o45VRWNpYL33m7JjCedWlaRbvx2yyMyHpvUCIzjgL927DXvQ9lu0UQOb6q8Fi5XyjCb1NqHoQdOhaO08h91Ip6A4OuiQjrpa4TsUg9QV0dcPqdPkkm1tEx14UG7X611NOch6kUDSL4IorTS3uBpGpCgj0UVwScTtyOYWweQK2/C1zZKvy6vZmx60Z6xYRws4YxqX+5y4p1fpyfcZ1ZFtCG0NFW1LpztYTgbiGodZoYzf3gd/MqdoCb/6uUfzOpGCBPjEuPvwqgFUgSL0lqSwdA2+z3vYDjKdBmI5T2f5lqglIig+BEvlSn2i0QL/foLh7EuckWOrFoKP08W4hFaFR/Z3XBXEtyNvxu1DpllrMWZjeRaa4WLkoaryGA0y2vvoFY4SstGljCDSuGJc2I6PoZ2SEb0x18Zip0aN7UllhprPlOijWGU/aYYLng+M87vLCZ940b+zp2dKsk9C3HMJB2nckV80YqlGIdXeRGW+vmiLPidJNhmsTdoJLauQ3KUpwxIinTkMuoVElO1Bv+CigNMgrshKY23PVAFw9A3z+FvbUg7EAXnce2RMLypguBceH5GSeMaG0+jqxam769yzztezJ+JFcQQorXc=";
                
                options.IdentityProviderMetadataAddress = "https://dev-411274.okta.com/app/exketzt7voh6Hec3K357/sso/saml/metadata";
                options.RequireValidMetadataSignature = false;
                options.TimeComparisonTolerance = 120;
                options.ServiceProviderOptions = new SpOptions
                {
                    EntityId = "https://localhost:5001/saml",
                    MetadataPath = "/saml/metadata",
                    SignAuthenticationRequests = false
                };
                options.NameIdClaimType = "sub";
                options.CallbackPath = "/signin-saml";
                options.SignInScheme = IdentityConstants.ExternalScheme;

            })
            .AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            });

        }
 
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
