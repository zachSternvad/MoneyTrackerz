using MoneyTrackerz.Components;
// Importera din nya namespace för services
using MoneyTrackerz.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// ---- LÄGG TILL DENNA RAD ----
// Här registrerar vi TransactionService som en "Singleton".
// Det betyder att en enda instans av TransactionService kommer att skapas
// och återanvändas i hela applikationen. Perfekt för vår minneslista.
builder.Services.AddSingleton<TransactionService>();
// -----------------------------


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles(); // Denna rad fanns troligen redan, men se till att den är med.
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();