using System.Text;
using apicampo.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;


namespace apicampo
{
    public class Startup
    {
        public IConfiguration Configuration{get;set;}
        public Startup(IConfiguration configuration){
            Configuration=configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var key = Encoding.ASCII.GetBytes("UmTokenParaCampoLindoQueNinguemSabeMateus2414JuntoComBoasNov@s");

            services.AddAuthentication(options => {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
             })
             .AddJwtBearer(options => {
                options.RequireHttpsMetadata = false;
                options.SaveToken= true;
                options.TokenValidationParameters = new TokenValidationParameters{
                  ValidateIssuerSigningKey = true,
                  IssuerSigningKey = new SymmetricSecurityKey(key),
                  ValidateIssuer= false,
                  ValidateAudience = false,
                };
             });
           // services.AddDbContext<DataContext>(Options => Options.UseInMemoryDatabase("BDTarefas"));
           // services.AddDbContext<DataContext>(options => options.UseNpgsql(Configuration.GetConnectionString("Hirokupost")));
            services.AddDbContext<DataContext>(options => options.UseNpgsql(Configuration.GetConnectionString("Postgres")));
            services.AddTransient<ITarefaRepository, TarefaRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IVariaveisRepository, VariaveisRepository>();
            
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
         
        }
    }
}
