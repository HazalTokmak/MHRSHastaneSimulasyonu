using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRSHastaneSimulasyonu.UI.Models
{
    public class Randevu
    {
        public int Id { get; set; }
        public string HastaId { get; set; }
        public Hasta Hasta { get; set; }
        public string DoktorId { get; set; }
        public Doktor Doktor { get; set; }
        public DateTime Tarih { get; set; }
    }
}
