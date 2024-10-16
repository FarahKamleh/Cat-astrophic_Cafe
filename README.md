# Cat-astrophic Cafe
A serious multiplayer networked game following the theme "Computer Architecture and Cats", Cat-astrophic Cafe is a cat cafe that intends to educate the players on caching.

## Introduction

Group Name: Cat-astrophic Cafe

Group Members: Lisset Rico and Farah Kamleh

Brief Game Description: With the intention of teaching players about caching, players take banana smoothie and banana sundae orders at a cat cafe and deliver them to customers. The ingredients are stored in fridges at opposing sides of the preparation areas, so the players must be diligent in selecting the correct ingredients to store on the counter between both players which is representative of the cache.

## Formal Elements

Player Interaction Pattern: The player interaction pattern is Cooperative Play. One player will be responsible for creating the smoothie orders while the other will be responsible for creating the sundae orders. The ingredients are on the opposite sides, so the players must work together to send items to each other using the counter (cache).

Objective: Prepare all of the smoothie and sundae orders within the time limit. It may loosely fall under Construction ("building" orders) and Solution (solve the problem before the time limit).
 
Serious Objective: Showcase to the player how caching can be used to serve future requests quicker by temporarily storing data.

Procedures: The "who" is two cat baristas (multiplayer), the "where" is the cat cafe, the "when" is the time limit, the "how" is keyboard/mouse input and networking. Use WASD to move the players, click on the fridge contents to grab ingredients, click again to release them, and place finished orders to deliver.

Rules: Players are limited to their side of the "kitchen". Player #1 can only prepare smoothie orders, fetch sundae ingredients, and deliver smoothie orders. Player #2 can only prepare sundae orders, fetch smoothie ingredients, and deliver sundae orders. The layout of the kitchen is intentional inefficient to require collaboration.

Resources: Time, ingredients (milk, banana, cherry, ice cream), and four "cache" baskets.

Non-Plain-Vanilla Procedure/Rule: Inefficient cafe layout that requires collaboration. Limited number of resources that can be carried/exchanged across the counter.

Test Question for Serious Objective: Why might caching be useful?

Expected Correct Answer for Serious Objective: It allows for quicker access for future requests.

## Fulfillment of Theme

The theme of the project is "Computer Architecture and Cats". The intention of the game is to educate the players about the usefulness of caching, placing emphasis on quicker access and temporary storage. Because the fridges are on opposing sides of the room with opposing ingredients, having the players run across the room to gather what they need is inefficient. Therefore, the counter in between both players with four baskets must be used to store ingredients that they need. This will allow the players to complete their tasks within the time limit.

The counter is representative of the cache. It only has four baskets which communicates the limited storage of cache memory. In addition, having ingredients placed in the center where both players have quick access showcases the time reduction achieved by caching. In other words, data can now be served faster. Lastly, the location is a cat cafe where the employees and the customers are all cats in banana costumes which matches the items they are serving: banana smoothies and banana sundaes.

## Later Additions

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
