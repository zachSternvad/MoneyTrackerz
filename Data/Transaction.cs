// Fil: Data/Transaction.cs
using System.ComponentModel.DataAnnotations;

namespace MoneyTrackerz.Data;

public enum TransactionType
{
    Income,
    Expense
}

public class Transaction
{
    // Unik identifierare för transaktionen.
    public Guid Id { get; set; } = Guid.NewGuid();
    
    // Datum för transaktionen.
    public DateTime Date { get; set; } = DateTime.Now;

    // Beskrivning, obligatoriskt fält.
    [Required(ErrorMessage = "Du måste ange en beskrivning.")]
    public string Description { get; set; } = string.Empty;

    // Belopp, måste vara större än noll.
    [Range(0.01, double.MaxValue, ErrorMessage = "Beloppet måste vara större än 0.")]
    public decimal Amount { get; set; }

    // Typ av transaktion (Inkomst/Utgift).
    public TransactionType Type { get; set; }

    // --- NY EGENDOM HÄR ---
    /// <summary>
    /// Identifieraren för den kategori som transaktionen tillhör.
    /// Detta är en "Foreign Key" till Category-modellen.
    /// "int?" betyder att den är "nullable", dvs en transaktion inte måste ha en kategori.
    /// </summary>
    public int? CategoryId { get; set; }
}