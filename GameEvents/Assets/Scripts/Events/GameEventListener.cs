using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [System.Serializable]
    public struct EventListenReponse
    {
        public GameEvent GameEvent;

        public UnityEvent Response;
    }

    public List<EventListenReponse> GameEvent_Listeners = new List<EventListenReponse>();

    private void OnEnable()
    {
        foreach(EventListenReponse lR in GameEvent_Listeners)
        {
            lR.GameEvent.RegisterListener(this);
        }
    }

    private void OnDisable()
    {
        foreach (EventListenReponse lR in GameEvent_Listeners)
        {
            lR.GameEvent.UnRegisterListener(this);
        }
    }

    public void OnEventRaised()
    {
        foreach (EventListenReponse lR in GameEvent_Listeners)
        {
            lR.Response.Invoke();
        }
    }
}
