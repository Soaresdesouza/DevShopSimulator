using Microsoft.OpenApi.Models;

namespace DSS.Identidade.API.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(name: "DevShopSimulator-V1", new OpenApiInfo
                {
                    Title = "DevShopSimulator Identidade API",
                    Description = "A API faz parte do projeto DevShopSimulator e é projetada para gerenciar a autenticação de usuários de maneira eficaz e segura.",
                    Contact = new OpenApiContact() { Name = "Thiago Souza", Email = "contato@devshop.com.br" },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri(uriString: "https://opensource.org/licences/mit") }
                });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(url: "/swagger/DevShopSimulator-V1/swagger.json", name: "DevShopSimulator-V1");
            });

            return app;
        }
    }
}
