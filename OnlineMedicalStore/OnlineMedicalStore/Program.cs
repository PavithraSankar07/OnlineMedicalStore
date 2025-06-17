using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;
using OnlineMedicalStore.Client.Pages;
using OnlineMedicalStore.Components;
using OnlineMedicalStore.Service;

// Entry point to create the application (chief archietect to start the design of given land)
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Its like a room building (.razor files into HTML)
builder.Services.AddRazorComponents()
// Enables Blazor Server interactivity. It sets up the SignalR real-time connection infrastructure.
    .AddInteractiveServerComponents()
    // Enables Blazor WebAssembly interactivity. It tells the server how to serve the .wasm and .dll files to the browser.
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddServerSideBlazor()
    .AddCircuitOptions(options => { options.DetailedErrors = true; });
builder.Services.AddControllers();
// Need to understand
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped(hc => new HttpClient { BaseAddress = new Uri("http://localhost:5234") });
builder.Services.AddAuthentication("Cookies").AddCookie(Options
=>
{
    Options.Cookie.Name = "Cookies";
    Options.LoginPath = "/";
    Options.AccessDeniedPath = "/accessdenied";
});

// builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState(); 

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

app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.UseAntiforgery();
app.MapControllers();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(OnlineMedicalStore.Client._Imports).Assembly);
// app.MapauthEndpoints();
app.Run();
























// -------------------------------------------------------------------------------------------------------------------

// using OnlineMedicalStore.Client.Pages;
// using OnlineMedicalStore.Components;
// using OnlineMedicalStore.Service;

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// builder.Services.AddRazorComponents()
//     .AddInteractiveServerComponents()
//     .AddInteractiveWebAssemblyComponents();
// builder.Services.AddScoped<UserService>();
// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseWebAssemblyDebugging();
// }
// else
// {
//     app.UseExceptionHandler("/Error", createScopeForErrors: true);
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }
// app.UseHttpsRedirection();
// app.UseStaticFiles();
// app.UseAntiforgery();
// app.MapRazorComponents<App>()
//     .AddInteractiveServerRenderMode()
//     .AddInteractiveWebAssemblyRenderMode()
//     .AddAdditionalAssemblies(typeof(OnlineMedicalStore.Client._Imports).Assembly);

// app.Run();
