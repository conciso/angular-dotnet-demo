using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDotnetDemo.Core.Dto;

public record Event(string Name, string ImagePath, string Location, DateTime EventDay) { }
