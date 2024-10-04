namespace AngularDotnetDemo.Core.Entities;

public class Event
{
  public required long Id { get; set; }
  public required string Name { get; set; }
  public required string Description { get; set; }
  public required string ImagePath { get; set; }
  public required string Location { get; set; }

}
