using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pract.Models
{
    public class Work
    {
        [Key]
        public int work_Id { get; set; }
        public int comp_Id { get; set; }
        public string work_Name { get; set; }
    }
}
