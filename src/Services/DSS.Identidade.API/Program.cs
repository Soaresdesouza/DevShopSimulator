using DSS.Identidade.API.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationsDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationsDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc(name: "DevShopSimulator-V1", new OpenApiInfo
    {
        Title = "DevShopSimulator Identidade API",
        Description = "A API faz parte do projeto DevShopSimulator e é projetada para gerenciar a autenticação de usuários de maneira eficaz e segura.",
        Contact = new OpenApiContact() { Name = "Thiago Souza", Email = "contato@devshop.com.br" },
        License = new OpenApiLicense() { Name = "MIT", Url = new Uri(uriString: "https://opensource.org/licences/mit") }
    });
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint(url: "/swagger/DevShopSimulator-V1/swagger.json", name: "DevShopSimulator-V1");
});
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
