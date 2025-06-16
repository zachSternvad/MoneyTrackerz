using System.ComponentModel.DataAnnotations;

namespace MoneyTrackerz.Data;

/// <summary>
/// Representerar en kategori som en transaktion kan tillhöra,
/// till exempel "Mat", "Boende" eller "Nöje".
/// </summary>
public class Category
{
    /// <summary>
    /// En unik numerisk identifierare för kategorin.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Namnet på kategorin.
    /// Detta fält är obligatoriskt och måste ha ett värde.
    /// </summary>
    [Required(ErrorMessage = "Du måste ange ett namn för kategorin.")]
    public string Name { get; set; } = string.Empty;
}