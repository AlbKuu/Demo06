using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Song
    {
        public string SongName { get; set; }
        public double SongLength { get; set; }
        
        public override string ToString()
        {
            return SongName + " " + SongLength + " ";
        }
    }
}
