namespace InventoryManagement;

interface IFurnitureInventoryBuilder
{
  IFurnitureInventoryBuilder AddTitle();
  IFurnitureInventoryBuilder AddDimensions();
  IFurnitureInventoryBuilder AddLogistics(DateTime date);

  // In traditional implementation each concrete
  // builder would have a method to return its built
  // instance.
  InventoryReport GetDailyReport();
}
