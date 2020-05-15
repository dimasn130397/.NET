using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPos.DataModel
{
    public class Pagination
    {
        public Pagination()
        {
            Pages = 0;
        }
        //Total page
        public int Pages { get; set; }
        public object ListOf { get; set; }
    }
}
