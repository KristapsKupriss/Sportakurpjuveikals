using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports.Data;

    public class Bernufutbolabuci
    {
        [Key]
        public int ID { get; set; }
        public string? Modelis { get; set; }
        public double Cena { get; set; }
    }

