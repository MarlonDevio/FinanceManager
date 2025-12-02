namespace Entities;

public class Account
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? AccountType { get; set; }
    public string? Currency { get; set; }
    public decimal? CurrentAmount { get; set; }
}
