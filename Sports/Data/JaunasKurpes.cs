using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace Sports.Data;

public class JaunasKurpes
{
    [Key]
    public int Id { get; set; }
    public string? Modelis { get; set; }
    public double Cena { get; set; }
    public int CategoryId { get; set; }
    public int Qty { get; set; }

}

