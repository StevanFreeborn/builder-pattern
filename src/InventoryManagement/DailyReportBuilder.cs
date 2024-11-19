namespace InventoryManagement;

class DailyReportBuilder(IEnumerable<FurnitureItem> items) : IFurnitureInventoryBuilder
{
  private InventoryReport _report = new();
  private readonly IEnumerable<FurnitureItem> _items = items;

  public void Reset() => _report = new();

  public void AddTitle()
  {
    _report.TitleSection = "------ Daily Inventory Report ------\n\n";
  }

  public void AddDimensions()
  {
    _report.DimensionsSection = string.Join("\n", _items.Select(item =>
      $"Product: {item.Name}\n" +
      $"Price: ${item.Price}\n" +
      $"Dimensions: {item.Width} x {item.Height} in\n" +
      $"Weight: {item.Weight} lbs\n\n"
    ));
  }

  public void AddLogistics(DateTime date)
  {
    _report.LogisticsSection = $"Report generated on {date}\n";
  }

  public InventoryReport GetDailyReport()
  {
    InventoryReport report = _report;
    Reset();
    return report;
  }
}