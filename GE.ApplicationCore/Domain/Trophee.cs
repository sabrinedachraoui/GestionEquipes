using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.ApplicationCore.Domain
{
    public class Trophee
    {
        public DateTime DateTrophee { get; set; }
        public double Recompense { get; set; }

        public int TropheeId { get; set; }

        public String TypeTrophee { get; set; }

        public Equipe Equipe { get; set; }
    }
}
