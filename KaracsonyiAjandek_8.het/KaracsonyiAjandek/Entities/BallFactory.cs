using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaracsonyiAjandek.Entities
{
    class BallFactory : IToyFactory
    {
        public Ball CreateNew()
        {
            return new Ball();
        }
    }
}
