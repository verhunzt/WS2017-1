using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvv2.ViewModel
{
    class MainViewModel
    {


        public List<string> Shapes { get; set; }

        public string Bezeichnung { get; set; }

        public MainViewModel()
        {
            Shapes = new List<string> { "Rechteck",
            "Kreis"};
        }


    }
}
