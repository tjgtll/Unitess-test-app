using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Unitess_test_app.DAL.Interface;
using Unitess_test_app.DAL.Repo;
using Unitess_test_app.BLL.Services.IServices;
using Unitess_test_app.BLL.Services;
using Unitess_test_app.DAL.DataContext;

namespace Unitess_test_app.IoC
{
    public static class DependencyInjection
    {
        public static void InjectDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            var connectionStringsOption = new DbContext();
            Configuration.GetSection(ConnectionStringsOption.ConnectionStrings).Bind(connectionStringsOption);
            services.AddScoped<IContactRepo,ContactRepo>();
            services.AddScoped<IContactService, ContactService>();
            
        }
    }
}
