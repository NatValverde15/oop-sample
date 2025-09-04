namespace ACME.OOP.SCM.Domain.Model.ValueObjects;
/// <summary>
/// Value object representing a unique identifier for a supplier.
/// </summary>
public record SupplierId
{
    public string Identifier { get; init; }
    /// <summary>
    /// Creates a new instance of SupplierId.
    /// </summary>
    /// <param name="identifier"></param>
    /// <exception cref="ArgumentException"></exception>
    public SupplierId(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentException("Supplier identifier cannot be null or empty.", nameof(identifier));
        Identifier = identifier;
    }
};