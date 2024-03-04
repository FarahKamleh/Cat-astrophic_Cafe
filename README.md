# CS426_Kamleh_Farah_Asgn4
This assignment is an extension of Assignment #4. This version includes Additional physics, textures, and lights.

## Additions

### Lighting

Two types of lights have been added in addition to the one that existed in the original version:

1. Stationary, pink point lights to illuminate the interiors of the two fridges.
2. Pink spotlights above the delivery baskets that are revealed by building the correct order. They remain lit until the user removes the finished order with a click.

### Physics Constructs

Two physics-related additions have been made which are linked to each other:

1. A 3D model of a bell sits on the front counter. When a collision occurs between the box collider of the bell and that of the player, a ringing sound is heard and the following physics-related addition happens.
2. After the bell has been "pressed", gravity is triggered and the banana cat customers fall from the sky and land on the ground in front of the delivery basket.

### Textures/Billboards

A single billboard with a texture has been added:

1. A sign informing the user to ring the bell to receive customers is located on the front counter. It includes a texture of a cartoon reception bell.

## Fitting Into Overall Design

The five additions described above expand upon the existing interaction and setting. The static point light in the fridge not only simulates the real thing, but also allows for the ingredients to be better seen. The spotlight is further confirmation that an order has been completed. The billboard provides instructions for a new interaction which is collision-based. When the bell is rung, customers arrive.

## Credits

The PlayerMovement.cs script is a modified version of the script provided by the course's teaching assistant Md Nafiul Nipu. Through his guidance, the multiplayer networking of the game was achieved which includes the use of the NetworkManagerUI script.

For additional assets, all credits have been included in the text file located in the repository titled, "CS 426 - Assignment 2 - Credits.txt". For futher information, all the 3D models used were downloaded from Sketchfab with permission from the artists. They are the following:

Banana Cat - SOBOL,
Fridge - LongLight,
Door - qwertderstar,
Banana - Batuhan13,
Banana Smoothie - markus.blend,
Cherry - pizzaguyty,
Milk - beelur,
Banana Split - DTStheTDS,
Ice Cream - adityajaiswal9968,
Blender - giga,
Hanging Light - FlipTheBird,
Table Bell - gla_bot,
and Basket - PRINCE.JACK.