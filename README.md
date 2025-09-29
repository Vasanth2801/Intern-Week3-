# Intern-Week3-
Task : Enemy navmeshagent and AI 

What I have Learned :
* How to make the enemy for the player using the A* pathfinder package system 

Implementation(Step by Step):
* First imported the pathfinder package and add it to the unity Scene and then created a new empty gameobject called A* and add the inbuilt script whicch make s the work very ease
* Now in the A* gameobject we will add the pathfinder script to it and click the grid graph on for the 2D one and then we will scan the surface of the game which will make the path for the 
  enemy
* Now in the layer we will add new layer and make that alone as not able to scan and make it as real obastacle for both enemy and player
* Now in enemy we have add three scripts Seeker,AIpath(2D,3D) and AI destination setter for the enemy to follow efficiently 

Features Implemented:
* Enemy AI which follows the player smartly using A* pathfinder 
