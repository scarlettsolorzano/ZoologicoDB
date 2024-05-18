using Microsoft.EntityFrameworkCore;
using Zoologico.Client.Pages;
using Zoologico.Components;
using Zoologico.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Zoologico.Modelo.ZoologicoDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//Inyeccion de dependencias
builder.Services.AddScoped<IRepositorioPersonas, RepositorioPersonas>();
builder.Services.AddScoped<IRepositorioAreas, RepositorioAreas>();
builder.Services.AddScoped<IRepositorioAnimales, RepositorioAnimales>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Zoologico.Client._Imports).Assembly);

app.Run();
