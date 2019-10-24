using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "Events/GameEvent")]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> EventListeners = new List<GameEventListener>();

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
