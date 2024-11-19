using InventoryManagement;

List<FurnitureItem> items = [
  new("Sofa", 399.99, 34.5, 89.0, 155.0),
  new("Coffee Table", 199.99, 18.0, 50.0, 45.0),
  new("Bookshelf", 149.99, 31.0, 11.0, 65.0),
  new("TV Stand", 599.99, 25.0, 70.0, 85.0)
];

var builder = new DailyReportBuilder(items);
var director = new InventoryBuildDirector(builder);

director.BuildCompleteReport();
Console.WriteLine(builder.GetDailyReport().Debug());