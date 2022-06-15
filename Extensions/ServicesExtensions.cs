using EmployeeManagement.Repository;
using MediatR;

namespace EmployeeManagement.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            //setup our DI
            services
                .AddScoped<IDataAccess, DataAccess>()
                .AddMediatR(typeof(DataAccess).Assembly);           
        }

    }
}
