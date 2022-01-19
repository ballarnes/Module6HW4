namespace MVC.ViewModels;

public record Brands
{
    public int PageIndex { get; init; }
    public int PageSize { get; init; }
    public int Count { get; init; }
    public List<CatalogBrand> Data { get; init; }
}