using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pract.Models
{
    public class Comp
    {
        [Key]
        public int comp_Id { get; set; }
        public string comp_Name { get; set; }
    }
}
