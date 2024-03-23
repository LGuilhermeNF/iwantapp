using Flunt.Validations;
using System.Diagnostics.Contracts;

namespace IWantApp.Domain.Products;

public class Category : Entity
{
    public string Name { get; private set; }
    public bool Active { get; private set; }

    public Category(string name, string createdBy, string updatedBy)
    {
        Name = name;
        Active = true;
        CreatedBy = createdBy;
        CreatedOn = DateTime.Now;
        UpdatedBy = updatedBy;
        UpdatedOn = DateTime.Now;

        Validate();
    }

    private void Validate()
    {
        var contract = new Contract<Category>()
                    .IsNotNullOrEmpty(Name, "Name")
                    .IsGreaterOrEqualsThan(Name, 3, "Name")
                    .IsNotNullOrEmpty(CreatedBy, "CreatedBy")
                    .IsNotNullOrEmpty(UpdatedBy, "UpdatedBy");
        AddNotifications(contract);
    }

    public void UpdateInfo(string name, bool active)
    {
        Active = active;
        Name = name;
        Validate();
    }
}
