using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProtonDeflectometry
{
    public class Simulation
    {
        //number of particles, energy, grid distance, screen distance
        public int npart;
        public double E;
        public double gridDist;
        public double screenDist;
        public double gridSize = 0.1;
        public double screenSize = 0.4;
        List<Particle> particles = new List<Particle>();
        public double[,] points;
        public int cameraResolution = 100;
        public int[,] camera;

        public Simulation(int n, double Energy, double GD, double SD)
        {
            npart = n;
            E = Energy;
            gridDist = GD;
            screenDist = SD;
            start();
        }

        void initParticles()
        {

            Random rand = new Random();
            //double m = 1.66e-27;
            //E = E * 1000 * 1.6e-19;
            double m = 1.0;
            for (int i = 0; i < npart; i++)
            {
                double thetamax = Math.Atan(gridSize / (2 * gridDist));
                double phimax = Math.Atan(gridSize / (2 * gridDist));
                //Console.WriteLine(gridSize);
                double theta = Math.PI/2.0 + rand.NextDouble() * 2 * thetamax - thetamax;
                double phi = rand.NextDouble() * 2 * phimax - phimax;
                //Console.WriteLine(theta);
                //double thetamax = Math.Atan(gridSize / (2 * gridDist));
                //double phimax = Math.PI * 2.0;
                //double theta = rand.NextDouble() * 2 * thetamax - thetamax;
                //double phi = rand.NextDouble() * phimax;

                double E_spread = E * 0.2;
                double E_rand = E + rand.NextDouble() * E_spread - E_spread / 2.0;
                double v = Math.Pow(2 * E_rand / m, 0.5);
                double vx = v * Math.Sin(theta) * Math.Sin(phi);
                double vy = v *  Math.Cos(theta);
                double vz = v * Math.Sin(theta) * Math.Cos(phi);
                //Console.WriteLine(vz);
                //double vx = v * Math.Cos(theta) * Math.Sin(phi);
                //double vy = v * Math.Sin(theta) * Math.Cos(phi);
                //double vz = v * Math.Cos(theta) * Math.Cos(phi);
                double[] vel = new double[3] { vx, vy, vz };
                double[] pos = new double[3] { 0, 0, -gridDist };
                Particle part = new Particle(m, 1.0, pos, vel);
                particles.Add(part);
                //Console.WriteLine("adding particle");
            }
        }

        void projectToGrid()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("grid_start.txt"))
            {
                for (int i = 0; i < particles.Count; i++)
                {
                    double timeToGrid = -particles[i].x[2] / particles[i].v[2];
                    particles[i].x[0] += particles[i].v[0] * timeToGrid;
                    particles[i].x[1] += particles[i].v[1] * timeToGrid;
                    particles[i].x[2] = 0;
                    //Console.WriteLine(timeToGrid);
                    //Console.WriteLine(particles[i].v[2]);
                    file.WriteLine(particles[i].x[0].ToString() + " " + particles[i].x[1].ToString() + " " + particles[i].x[2].ToString());
                }
            }
        }

        void propagateThroughGrid()
        {
            //double dt = 0.00000000001;
            double dt = 0.0001;
            double T = 1.0;
            double t = 0.0;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("grid_end.txt"))
            {
                using (System.IO.StreamWriter file2 = new System.IO.StreamWriter("traj_coords.txt"))
                {
                    while (t < T)
                    {
                        //Console.WriteLine(t);
                        //Console.WriteLine(particles[0])
                        bool wantTrajectories = false;
                        bool wantToBreak = true;
                        List<int> toBeRemoved = new List<int>();
                        for (int i = 0; i < particles.Count; i++)
                        {
                            ////This section removes the particles hitting the rod
                            ////Comment this out unless using z - pinch field
                            //double xcoord = particles[i].x[0];
                            //double zcoord = particles[i].x[2] - gridSize / 2.0;
                            //double rodr = 0.032;
                            //if (xcoord * xcoord + zcoord * zcoord < rodr * rodr)
                            //{
                            //    toBeRemoved.Add(i);
                            //    continue;
                            //}

                            if (particles[i].x[0] < -gridSize / 2 || particles[i].x[0] > gridSize / 2 ||
                                particles[i].x[1] < -gridSize / 2 || particles[i].x[1] > gridSize / 2)
                            {
                                toBeRemoved.Add(i);
                                continue;
                            }
                            if (particles[i].x[2] >= gridSize)
                            {
                                continue;
                            }
                            wantToBreak = false;
                            particles[i].x[0] += particles[i].v[0] * dt;
                            particles[i].x[1] += particles[i].v[1] * dt;
                            particles[i].x[2] += particles[i].v[2] * dt;
                            double[] acc = getAcc(particles[i]);
                            particles[i].v[0] += acc[0] * dt;
                            particles[i].v[1] += acc[1] * dt;
                            particles[i].v[2] += acc[2] * dt;
                            if (wantTrajectories)
                            {
                                file2.WriteLine(particles[i].x[0].ToString() + " " + particles[i].x[1].ToString() + " " + particles[i].x[2].ToString());
                            }
                        }
                        for (int i = 0; i < toBeRemoved.Count; i++)
                        {
                            particles.Remove(particles[toBeRemoved[toBeRemoved.Count - i - 1]]);
                        }
                        if (wantToBreak)
                        {
                            break;
                        }
                        t += dt;
                    }
                    foreach (Particle part in particles)
                    {
                        file.WriteLine(part.x[0].ToString() + " " + part.x[1].ToString() + " " + part.x[2].ToString());
                    }
                }
            }
        }

        double[] getAcc(Particle part)
        {
            double[] B = getB(part.x);
            double ax = (part.v[1] * B[2] - part.v[2] * B[1]) / part.m;
            double ay = (part.v[2] * B[0] - part.v[0] * B[2]) / part.m;
            double az = (part.v[0] * B[1] - part.v[1] * B[0]) / part.m;
            double[] acc = new double[3] { ax, ay, az };
            return acc;
        }

        double[] getB(double[] x)
        {
            //line current parallel to particle velocities
            //double Bmag = 3.0e-22;
            double Bmag = 1.0;
            double Bx = - Bmag / x[1];
            double By = Bmag / x[0];
            double Bz = 0.0;
            double[] B = new double[3] { Bx, By, Bz };
            //uniform y field
            Bx = 0.0;
            //By = 3e-20;
            By = 100.0;
            Bz = 0.0;
            double[] B2 = new double[3] { Bx, By, Bz};
            //line current perpendicular to particle velocities
            Bx = -Bmag / (x[2]-gridSize/2.0);
            By = 0;
            Bz = Bmag / x[0];
            double[] B3 = new double[3] { Bx, By, Bz };
            return B2;
        }

        void projectToScreen()
        {
            double[,] screenPoints = new double[npart, 2];
            for (int i=0; i<particles.Count; i++)
            {
                double timeToScreen = screenDist / particles[i].v[2];
                particles[i].x[0] += particles[i].v[0] * timeToScreen;
                particles[i].x[1] += particles[i].v[1] * timeToScreen;
                particles[i].x[2] = screenDist;
                screenPoints[i, 0] = particles[i].x[0];
                screenPoints[i, 1] = particles[i].x[1];
            }
            points = screenPoints;
        }

        public int[,] getCamera()
        {
            int[,] camera = new int[cameraResolution, cameraResolution];

            foreach (Particle part in particles)
            {
                if (part.x[0] > -screenSize / 2.0 && part.x[0] < screenSize / 2.0 && part.x[1] > -screenSize / 2.0 && part.x[1] < screenSize / 2.0)
                {
                    int x_coord = Convert.ToInt32(part.x[0] / screenSize * cameraResolution) + cameraResolution / 2;
                    int y_coord = Convert.ToInt32(part.x[1] / screenSize * cameraResolution) + cameraResolution / 2;
                    //int x_coord = Convert.ToInt32(part.x[0] * 2 / screenSize * cameraResolution) + cameraResolution / 2 + 1;
                    //int y_coord = Convert.ToInt32(part.x[1] * 2 / screenSize * cameraResolution) + cameraResolution / 2 + 1;
                    //Console.WriteLine(x_coord);
                    //Console.WriteLine(y_coord);
                    camera[x_coord, y_coord] += 1;
                }
            }
            return camera;
        }

        void start()
        {
            initParticles();
            projectToGrid();
            propagateThroughGrid();
            projectToScreen();
            //calculateCamera();
        }
        
    }
}
