using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceDanceApp.Entities
{
    public class SkateFactory
    {
        public Skate CreateNew()
        {
            return new Skate();
        }
    }
}
