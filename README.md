# Deflectometry

## The code

This is a proton deflectometry file written in C#. The results are shown in a picture box and a scatter plot. The particle trajectories are also written out to a file called traj_coords.txt, you can visualize that if you can do a 3D scatter plot. The included files can be opened by opening the .sln file with Visual Studio.

## What is proton deflectometry?

There is a proton source a certain distance away from the grid. The protons are initialized with a range of energies, and a range of directions. They propagate forward to the grid. In the grid, an Euler method is used to solve the motion under a magnetic field. After the grid, they propagate forward to the screen. The protons hitting the screen are recorded. Different patterns on the screen can be observed for different magnetic fields.
