using System.Text;

namespace InventoryManagement;

class InventoryReport
{
  public string TitleSection = string.Empty;
  public string DimensionsSection = string.Empty;
  public string LogisticsSection = string.Empty;

  public string Debug() => new StringBuilder()
    .AppendLine(TitleSection)
    .AppendLine(DimensionsSection)
    .AppendLine(LogisticsSection)
    .ToString();
}

class InventoryBuildDirector(IFurnitureInventoryBuilder builder)
{
  private readonly IFurnitureInventoryBuilder _builder = builder;

  public void BuildCompleteReport()
  {
    _builder.AddTitle();
    _builder.AddDimensions();
    _builder.AddLogistics(DateTime.Now);
  }
}