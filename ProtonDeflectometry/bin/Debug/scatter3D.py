
from mpl_toolkits.mplot3d import Axes3D
import matplotlib.pyplot as plt
import numpy as np

#fname = sys.argv[1]
fname = 'traj_coords.txt'
print('Started importing data')
f = open(fname, 'r')
data = np.array([[float(x) for x in line.split()] for line in f.readlines()])
print('Finished importing data')
f.close()
print(data.shape)

fig = plt.figure(1)
ax = fig.add_subplot(111, projection='3d')
ax.scatter(data[:, 0], data[:, 1], data[:, 2], c='b', s=0.1)
limit = 0.05
ax.set_xlim(-limit, limit)
ax.set_ylim(-limit, limit)
ax.set_zlim(0., 2*limit)
ax.set_xlabel('x axis')
ax.set_ylabel('y axis')
ax.set_zlabel('z axis')
plt.show()
print('done!')

