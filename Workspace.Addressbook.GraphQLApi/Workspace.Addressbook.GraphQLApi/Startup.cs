using HotChocolate;
using HotChocolate.Data.Filters;
using HotChocolate.Data.Filters.Expressions;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using Workspace.Addressbook.GraphQLApi.Domain;
using Workspace.Addressbook.GraphQLApi.GraphQL;
using Workspace.Addressbook.GraphQLApi.GraphQL.CustomFilters;

namespace Workspace.Addressbook.GraphQLApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Register mediatr
            services.AddMediatR(Assembly.GetExecutingAssembly());

            // Register DbContext
            services.AddDbContext<DNBCustomContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SqlDbConnection")));

            // Register graphQL schema
            services
                .AddRouting()
                .AddGraphQLServer()
                .AddProjections()
                .AddFiltering()
                .AddSorting()
                .AddQueryType<Query>()
                .AddConvention<IFilterConvention>(new FilterConventionExtension(
                                                    x => x.AddProviderExtension(
                                                        new QueryableFilterProviderExtension(
                                                            y => y.AddFieldHandler<QueryableStringInvariantEqualsHandler>()))));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Configure graphQL endpoint
                endpoints.MapGraphQL();
            });
        }
    }
}
