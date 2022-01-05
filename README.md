# GameEvents
A game event system that stores events and event rewards inside of ScriptableObjects.

Based off of the Unite 2017 Austin talk.

Take a Look around the project for details.

The example in the project is triggering a simple event and also for rewarding a Character based on an event being triggered.

For a non-reward GameEvent:
1. Create a ScriptableObject GameEvent
2. Create something to raise the GameEvent (in this example the RaiseOnInteract script uses KeyCode.E)
3. Attach a Game Event Listener to an object you want listening to the event and attach the GameEvent you are listening for to it
4. Create a Script that will have a public function to be called by the Game Event Listener UnityEvent response
5. Raise the event and watch it all come together

For a Character reward based GameEvent:
1. Create a ScriptableObject GameEvent
2. Create something to raise the GameEvent (in this example the RaiseOnInteract script uses KeyCode.E)
3. Attach a Game Event Listener to an object you want listening to events for a Character
4. Create a Character that will have 'stuff' rewarded to it (Currency in this example)
5. Create te Character Event Processor
6. Create the Event Reward Dictionary
7. Attach the Event Reward Dictionary to the Character Event Processor
8. Assign a GameEvent to the Game Event Listener
8. On the Game Event Listener Add the Character Event Processor three times (UnityEvents are limited to one parameter at a time)
9. Attach the proper parameters the Functions getCharacter and getGameEvent on the Event Listener
10. Attach function SendReward to the last slot on the Game Event Listener
11. Raise the event and watch it all come together

A faster summary once you have the infrastracture in place for the character is:
1. Create GameEvent
2. Add a Listener for the GameEvent
3. Setup the Listener for the Character and GameEvent
4. Raise the Event
