using System.Collections.Generic;
using UnityEngine;

//the GameEvent itself that will be used to link together the different parts of the system
[CreateAssetMenu(fileName = "GameEvent", menuName = "Events/GameEvent")]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> EventListeners = new List<GameEventListener>();

    //pass (this) into EventListener so that it can be checked against what is currently being raised
    public void Raise()
    {
        for (int i = EventListeners.Count - 1; i >= 0; i--)
            EventListeners[i].OnEventRaised(this);
    }

    public void RegisterListener(GameEventListener listener)
    {
        if (!EventListeners.Contains(listener))
            EventListeners.Add(listener);
    }

    public void UnRegisterListener(GameEventListener listener)
    {
        if (EventListeners.Contains(listener))
            EventListeners.Remove(listener);
    }
}
