using MoneyTrackerz.Data;

namespace MoneyTrackerz.Services;

/// <summary>
/// En service-klass som hanterar all logik för transaktioner.
/// Just nu använder den en statisk lista för att lagra data i minnet.
/// Senare kommer vi byta ut detta mot en riktig databas.
/// </summary>
public class TransactionService
{
    // Vi använder en statisk lista så att datan finns kvar mellan sidladdningar.
    // Detta är en enkel lösning för utvecklingssyfte.
    private static readonly List<Transaction> _transactions = new();

    /// <summary>
    /// Hämtar alla transaktioner som finns lagrade.
    /// Metoden är asynkron (returnerar en Task) för att förbereda för framtida databasanrop.
    /// </summary>
    /// <returns>En lista med alla transaktioner.</returns>
    public Task<List<Transaction>> GetTransactionsAsync()
    {
        // Returnerar en kopia av listan för att undvika oavsiktlig modifiering.
        return Task.FromResult(_transactions.ToList());
    }

    /// <summary>
    /// Lägger till en ny transaktion i listan.
    /// </summary>
    /// <param name="transaction">Transaktionsobjektet som ska läggas till.</param>
    public Task AddTransactionAsync(Transaction transaction)
    {
        // Sätter ett nytt unikt ID för transaktionen.
        transaction.Id = Guid.NewGuid();
        _transactions.Add(transaction);
        
        // Task.CompletedTask används när en asynkron metod inte behöver returnera något värde.
        return Task.CompletedTask;
    }
}