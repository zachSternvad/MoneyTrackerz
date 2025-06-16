// Fil: Services/CategoryService.cs
using MoneyTrackerz.Data;

namespace MoneyTrackerz.Services;

/// <summary>
/// Hanterar all logik för att hämta och spara kategorier.
/// Använder just nu en statisk minneslista.
/// </summary>
public class CategoryService
{
    // En statisk lista för att lagra kategorier i minnet.
    // Vi lägger till några standardkategorier för att komma igång.
    private static readonly List<Category> _categories = new()
    {
        new Category { Id = 1, Name = "Mat & Dryck" },
        new Category { Id = 2, Name = "Boende" },
        new Category { Id = 3, Name = "Transport" },
        new Category { Id = 4, Name = "Nöje" },
        new Category { Id = 5, Name = "Sparande" }
    };

    // En enkel räknare för att kunna ge nya kategorier ett unikt ID.
    private static int _nextId = 6;

    /// <summary>
    /// Hämtar alla tillgängliga kategorier.
    /// </summary>
    public Task<List<Category>> GetCategoriesAsync()
    {
        return Task.FromResult(_categories.ToList());
    }

    /// <summary>
    /// Lägger till en ny kategori i listan.
    /// </summary>
    public Task AddCategoryAsync(Category category)
    {
        // Tilldelar ett nytt ID till den nya kategorin.
        category.Id = _nextId++;
        _categories.Add(category);
        return Task.CompletedTask;
    }
}