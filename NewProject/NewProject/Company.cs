using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject
{
    [NotMapped]
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}