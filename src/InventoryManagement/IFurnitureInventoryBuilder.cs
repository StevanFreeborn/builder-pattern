namespace InventoryManagement;

interface IFurnitureInventoryBuilder
{
  void AddTitle();
  void AddDimensions();
  void AddLogistics(DateTime date);

  // In traditional implementation each concrete
  // builder would have a method to return its built
  // instance.
  InventoryReport GetDailyReport();
}
