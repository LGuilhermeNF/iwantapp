using IWantApp.Domain.Products;

namespace IWantApp.Domain;

public abstract class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CreateBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdateBy { get; set; }
    public DateTime UpdatedOn { get; set; }
}
