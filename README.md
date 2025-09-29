# Intern-Week3-
Task : Enemy navmeshagent and AI 

What I have Learned :
* How to make the enemy for the player using the A* pathfinder package system
* How to add an Melee and Ranged base enemies using navmesh
* How to add knockback force for player 

Implementation(Step by Step):
* First imported the pathfinder package and add it to the unity Scene and then created a new empty gameobject called A* and add the inbuilt script whicch make s the work very ease
* Now in the A* gameobject we will add the pathfinder script to it and click the grid graph on for the 2D one and then we will scan the surface of the game which will make the path for the 
  enemy
* Now in the layer we will add new layer and make that alone as not able to scan and make it as real obastacle for both enemy and player
* Now in enemy we have add three scripts Seeker,AIpath(2D,3D) and AI destination setter for the enemy to follow efficiently
* Added two different scripts for two different type of enemies (melee and ranged)
* Make them follow the player smartly using logic
* Added a knockback force when player collided with the Enemy

Features Implemented:
* Enemy AI which follows the player smartly using A* pathfinder
* Two types of enemies(Melee and Ranged) enemies that will following the player smartly
* Knockbackforce when player got touched 

Summary:
* Today I have learned about how to make enemies smartly follow the player which i have not worked on before 
