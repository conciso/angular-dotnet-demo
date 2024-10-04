using AngularDotnetDemo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDotnetDemo.Core.Dtos;

public record EventDto(string Name, string ImagePath, string Location, DateTime EventDay)
{
  public EventDto(Event @event) : this(@event.Name, @event.ImagePath, @event.Location, @event.EventDate)
  {
  }
}
