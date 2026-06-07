namespace TransactionLedger.Models;
using System.ComponentModel.DataAnnotations;

public class Account
{
    public int Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public decimal Balance {get; set;}
    [Timestamp]
    public byte[] RowVersion {get; set;} = [];
}