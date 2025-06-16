// Fil: Program.cs
using MoneyTrackerz.Components;
using MoneyTrackerz.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Registrerar TransactionService som en Singleton.
builder.Services.AddSingleton<TransactionService>();

// --- LÄGG TILL DENNA RAD ---
// Registrerar även CategoryService som en Singleton.
builder.Services.AddSingleton<CategoryService>();
// -----------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();