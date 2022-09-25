using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesSistemi.Models.Bases
{
    public class Gezegen : GokCismiBase
    {
        public bool YasamVarMi { get; set; }
        public int YildizId { get; set; }   
        public int[] UyduIdleri { get; set; }
    }
}
