using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAsp.Pages;

public class Categories : PageModel
{
    public List<Category> CategoriesList { get; set; } = new();

    public void OnGet( int skip = 0, int take = 25) //[FromQuery]
    {
        var category = new List<Category>();
        for (int i = 0; i <= 100; i++)
        {
            category.Add(
                new Category(i,
                    $"Title {i}",
                    i * 18.95M));
        }

        CategoriesList = category.Skip(skip)
            .Take(take)
            .ToList();
    }

    public record Category(
        int Id,
        string Title,
        decimal Price
    );
}