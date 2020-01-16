# Project-Aeroshot-3.0
Project-Aeroshot-3.0

Version Alpha 0.5b

# Game Design Team
- Fabian Sales - Programmer
- Joshua Cardenas - Tester and suggester
- Yesenia (i dunno her last name) - Artist


# Game Design Basic Information
Theme: 2020 Olympics
Event: Archery

Idea: the player has to explore a small level, defeat enemies and solve puzzles to advance to other levels

Game/Project Name: Project Aeroshot
Current Project Build: 3.4 Alpha Build 02

Features that we want to include:
- [ ] HD Textures and Models
- [ ] Platformer Elements
- [X] Settings Menu
- [ ] Sound Effects
- [X] Archery
- [X] Player Movement and Camera Control
- [ ] Music
- [ ] Puzzles
- [X] Tutorial
- [X] Main Menu
- [X] Pause Menu

# Development Process
We started by discussing what event in we should go for so of course none of us ever actually sitting down and watching the olympics we all sat down and did research on different events after researching and discussing which events seemed interesting to us we narrowed it down to the following events

- Archery
- Athletic Events
- Boxing
- Fencing
- Karate
- Taekwondo
- Weightlifting

After a few more talks and more than 0 arguments we agreed on Archery because as it stands Fabian may know quite a bit of C# his knowledge is also limited and he was unsure he could program Karate, Boxing, Fencing, or Taekwondo, which left us with Archery, Athletic events and Weightlifting.
	
When it came to Athletic events and weightlifting we had trouble coming up with interesting ideas for them as many of the ideas we could come up with just ended up becoming 
> hit these two buttons for minutes on end

and though it would have been simple to program it wouldn't have been interesting and would have been rather tedious.

After agreeing on Archery we had to choose exactly what we wanted to do with the event we opted against making a 2D game where you just aim and shoot and began work on a 1st person 3D Puzzle Platformer

# Game Development
Development started in a very chaotic fashion with nobody having any idea what to do in fact before even getting started we pushed the project aside for the month and came back to it in November however even while the project was sitting on the shelf we kept thinking about ideas for it however not frequently

Finally after coming back to the project Fabian assigned roles assigning Yesenia as the artist and Josh as an all around help as he suggests things to add, things to change and tests the games however he is also learning to program.

For the game we also decided on Using the Unity Engine and more specifically Unity’s Lightweight Render Pipeline as it allows for use of they're Post Processing System, and Shader Graph which though not extremely important we thought would help with making the game look better all around

After getting started Yesenia got to work on sketching a bow as well as enemies for the game, meanwhile Fabian began work on… the… title screen… yep, meanwhile Josh attempted to get Fabian to actually work on the game rather than the Title Screen, and after successfully getting him on task the two began working on a simple player script this simple character movement and camera as well as a small terrain plane was Build Alpha 1.0 build 01

We continued to come i and try to progress further but Josh and Fabian became stuck on what to add next
> do we add stats or the bow?

the question would continue to be asked for the next week while Yesenia made the bow sketch, at some point while sketching Yesenia drew a cute little snowman on her paper which fabian took a liking to and wasted no time entering Blender a free and powerful 3D Modeling and Animation Software and recreating the snowman sketch into 3D for use as an enemy for the game, this would coincidentally solve the question of bow or stats by replacing both options with
>I NEED TO GIVE THIS LIFE!!!

and fabian got to work not on the bow or stats but adding a simple AI script for the Snowman and adding a bow and then stats in that order. And this would be Build: Alpha 2.0 build 3

Currently we are on build Alpha 3.4 Build 02 which contains all the things mentioned in builds 1.0 and 2.0 as well as targets, a 
> Examine Menu

giving the player info on their target, A tutorial, Settings, A main menu and finally basic Textures also this was all done while Fabian was in mexico meaning all assets and code either had to be recycled from other projects or done before he left thanks you Josh and Yesenia for getting things done before and while Fabian left.

# Issues
During our little journey we had our issues some small some big so heres a few that we faced during our development journey

1. None of us have ever watched the Olympics 
    >Solution: Google

2. arrows shoot to the side
    >Solution: change the script and apply force to “transform.Right” instead “transform.Forward” Or rotate model in Blender and keep transform.Forward

3. Sidetracking / distraction
    >Solution: schedule time with everyone and set a day to meetup and work for a bit

4. player is floating up
    >Solution: change “Gravity” float variable from a positive value to a negative value

5. Arrows Fly through the floor
    >Solution: apply a Box Collider to the arrow Prefab

6. Drawing on a computer (with a drawing tablet) is difficult
    >Solution: Draw on paper, and scan the drawing to a jpg or png or pdf later

7. Fabian keeps getting distracted
    >Solution: Let him listen to hamilton while coding

8. too many arrows lag the game
    >Solution: add Destroy(Arrow, 5) to the “Bow” script, this will destroy the arrow instance after 5 seconds

9. Arrows don’t stick into objects after hitting something
    >Solution: add a condition that destroys the “Arrow” script and “Rigidbody” Component if the arrow collides with anything

10. Arrows stick to each other if they collide mid air
    >Solution: destroy other arrow instances when they collide or include it as a feature cuz it could me a cool tool

11. Fabian Plays Hamilton at max Volume
    >Solution: there is none he won’t turn it down

12. Player can stand on arrows
    >Solution: don’t fix it, use it

13. Fabian went on vacation
    >Solution: he took his laptop and has wifi
