using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest1.ViewModel
{
    class MainViewModel
    {
        public MainViewModel(List<string> shapes)
        {
            Shapes = shapes;
        }

        public List<string> Shapes { get; set; }

        public string SelectedShape { get; set; }


    }
}
