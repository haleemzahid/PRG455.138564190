using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG455._138564190.DatabaseClasses
{
    class Screening
    {
        public int screeningId { get; set; }
        public int UserId { get; set; }
        public bool CloseContact { get; set; }
        public bool Travelled { get; set; }
        public bool Symptoms { get; set; }
        public DateTime Date { get; set; }
    }
}
