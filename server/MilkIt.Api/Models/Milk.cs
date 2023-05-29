using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilkIt.Api.Models
{
    public class Milk
    {
        public required int Id {get; set; }
        public required string Name {get; set; }
        public required string Type {get; set; }
        public required int Storage {get; set; }
    }
}
