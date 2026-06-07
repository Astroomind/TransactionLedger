using Microsoft.EntityFrameworkCore;
using TransactionLedger.Models;
namespace TransactionLedger.Data;

public class LedgerDbContext : DbContext
{
    public LedgerDbContext (DbContextOptions<LedgerDbContext> 
    options) : base(options) { } 
    public DbSet<Transaction> Transactions {get; set;}
    public DbSet<Account> Accounts {get; set;}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Account>()
			.Property(a => a.Balance)
			.HasColumnType("decimal(18,2)");

		modelBuilder.Entity<Transaction>()
			.Property(t => t.Amount)
			.HasColumnType("decimal(18,2)");
	}
}