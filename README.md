# Intern-Week3-

Task : Build the Final Game 

What I have Learned : 
* I have learned how to Create a Platformer type movements and enemys for the game
* Post processing and Lighting effects
* Boss Battles and Enemy types 

Controls:

* PlayerMovement - WASD or ArrowKeys
* Jumping - Space
* Shooting - LeftShift 



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

Task : Powerups and UI

What I have learned :
* First I learned to create powerups for different effects
* Then I have learned to how to do the shop items for game 

Implementation(Step by step):
* first created two gameobjects and make it trigger and added to the gameobjects and make it as a scriptable object
* Now we will make the player touches and it will do certain effects
* Now we will create a UI canvas for the shop of the upgrade system
* Added two upgrades and when we press the button the upgrade will increase 

Features Implemented:
* powerups for the player to pick for the health and speed
* Ui for the upgrade system 

Summary:
* Powerups for the player(Health and speed) implemeted which is new to me and the upgrade shop when the buy button pressed it will increase

Task : BossBattle Implementation 

What I have Learned:
* How to create a Healthbar System with coloured effect when it gets low
* How to implement the boss battle with phases and attack the player 

Implementation(Step by Step):
* First setup the scene with a player and a ground which makes the platformer to fight the boss
* Now add the sprite for the boss and make the sprite a little bigger which makes it look like a boss
* Now lets make the health bar for the boss which if the player do damages the health will go down with a colour effect
* Now We will add the logic script for the health effect shich will decrease as the player damages the enemy and we wil know the health by the colour of the bar up
* Then I Moved to the Boss Animations from the sprite I have downloaded they are idle,run and jump animations but the intro animation was not there
* So I thought of creating it using the  properities of the Sprite it has and make the enemy come fall from above and then assemble the body and then start attcking
* And came out pretty good as expected and then I moved to the animator window and set it the intro animation as entry from that to the idle and run animations
* Now using the script we will make the state behaviour for the boss
* Now created new three scripts for the boss one for flipping,attacking and handling the states for the enemy to attack the player 

Features Implementated:
* Health bar system for the boss
* Intro Animations for the Boss when the game Starts
* Boss attacking the player with normla and rage modes 


Task : UI workflows 

What I have Leanred :
* How to create Start menu,settings menu and pause menu with animations
* How to create a wave animations for the enemy waves
* How to add UI transtions and adjusting the screen size according ti the scene 

Implementation(Step by step):
* First created a Ui and added the acoording buttons to that and add the logic to the functions
* We will create some UI animations for smoth trantions
* Also we will add some animations for waves enemy and saving the highscore data 

Features Implemented:
* Ui for the Game
* Animations for the UI transtions
* Scoring the Data and Scores


Task : Parallax and visual effects

What I have learned:
* How to create a background parallax moving background
* Lighting and postprocessing effects
* Particle eefects and slowmotion effects

Implementatio(Step by step):
* Created the scene and added the backgrounds for it   and added the logics for it
* Created the Gloabal volume and added the post processsing for the bloom
* Created  the Particles effect for the powerups and bullet colliding 

Features Implemented:
* Parallax Backgrounds
* PostProcessign and light effects
* Particle effects for powerups and bullets


Task: Testing and Bugfixing 

* Understood the importance of findidng before submitting the project
* Coz i find varoius minor bugs which affects the player experince 

