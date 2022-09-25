using GunesSistemi.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesSistemi.Services.Bases
{
    internal class GokCismiService : IGokCismiService
    {
        GokCismiBase _gokCismi;

        public GokCismiBase[] Listele()
        {
            GokCismiBase[] gokCisimleri = new GokCismiBase[3];
            _gokCismi = new Yildiz()
            {
                Adi = "Güneş",
                Id = 0,
                SicaklikC = 2000,
                YariCap = 5000
            };
            gokCisimleri[0] = _gokCismi;
            _gokCismi = new Gezegen()
            {
                Adi = "Dünya",
                Id = 3,
                YariCap = 2000,
                YasamVarMi = true,
                YildizId = 0
            };
            gokCisimleri[1] = _gokCismi;
            _gokCismi = new Uydu()
            {
                Adi = "Ay",
                GezegenId = 3,
                YariCap = 50,
                Id = 11
            };
            gokCisimleri[2] = _gokCismi;
            return gokCisimleri;
        }
    }
}
