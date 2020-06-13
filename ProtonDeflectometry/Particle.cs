using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtonDeflectometry
{
    class Particle
    {
        public double m;
        public double r;
        public double[] x = new double[3];
        public double[] v = new double[3];

        public Particle(double mass, double radius, double[] pos, double[] vel)
        {
            m = mass;
            r = radius;
            x = pos;
            v = vel;
        }
    }
}
