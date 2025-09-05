namespace ACME.OOP.Procurement.Domain.Model.ValueObjects;
/// <summary>
/// Value Object representing an unique identifier.
/// </summary>
public record ProductId
{
   public Guid Id { get; init;}
   /// <summary>
   /// Creates a new instance of <see cref="ProductId"/>with the specified GUID.
   /// </summary>
   /// <param name="id"></param>
   /// <exception cref="ArgumentException"></exception>
   public ProductId(Guid id)
   {
      if (id == Guid.Empty)
         throw new ArgumentException("ProductId cannot be an empty GUID.", nameof(id));

      Id = id;
   }
   /// <summary>
   /// Generates a new unique <see cref="ProductId"/>.instance with a new GUID.
   /// </summary>
   /// <returns></returns>

   public static ProductId NewId() => new(System.Guid.NewGuid());
};