# Lab-4

# Explanation

For the observer design pattern, I basically made it so that the enemy dying upon touching the player adds score and plays the audio for enemy death. The way how I approached this is to declare an Action variable which can take in multiple functions as its value. Every other script can access this and what I did is that on the scripts I want to use, I add the functions I need onEnable and subtract them onDisable. Now when the enemy dies, I call the invoke function for the action variable I made which signals all the functions I've added to the action to do what they are required to do. In this case, playing the audio and adding score.

For the singleton pattern I basically made a persistent manager script. The script consists of creating a public static instance, and the variables that will persist through scene switches. If there is no instance, then it is set to the current particular instance thatt the code is running in and then call DontDestroyOnLoad() to not destroy the object as we move to another scene. If there is already an instance then we destroy the instance to prevent having a duplicate of the persistence manager.
