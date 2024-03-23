using IWantApp.Domain.Products;
using IWantApp.Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace IWantApp.Endpoints.Categories;

public static class CategoryGet
{
    public static string Template => "/categories/{id}";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] Guid id,ApplicationDbContext context)
    {
        var categories = context.Categories.Where(c => c.Id.Equals(id));
        var response = categories.Select(c => new CategoryResponse { Id = c.Id, Name = c.Name, Active = c.Active});

        return Results.Ok(response);
    }
}
