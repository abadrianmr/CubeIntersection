# CubeIntersection
The Mathematical solution consists of two projects, a library (Mathematics) that handles the problem logic and a test project (MathematicsTests) that tests the implemented functionalities.
To solve the problem, the Mathematics project has defined two classes:
1. Vector: Class of vectors that has the necessary mathematical tools to solve the problem and model points on Cartesian axes.
2. Cube: Class that models a cube and has the required functionalities of the problem (Determine if two cubes collide and calculate the intersected volume of two cubes).

Two classes were also defined to do the tests:
1. VectorTests: to test the features of Vector
2. CubeTests: to test the Cube functionalities

#In order to show son deign patterns others projects were added
1.Domain: in this project the entities were defined
1.1. Builder pattern were implemented in orter to construct a Cube.
2.Repository: Defines a repository to encapsulate the interaction with a posible database.
3.WpfUI: WPF projects that use dependency inyection (Autofac) to register repositories interfaces and navigation services.
