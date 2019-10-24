using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    //struct that ties a GameEvent and Response together
    [System.Serializable]
    public struct GameEventReponse
    {
        public GameEvent GameEvent;

        public UnityEvent Response;
    }

    //List of GameEvents and Responses that are tied together in a struct
    public List<GameEventReponse> GameEvent_Responses = new List<GameEventReponse>();

    private void OnEnable()
    {
        foreach(GameEventReponse lR in GameEvent_Responses)
        {
            lR.GameEvent.RegisterListener(this);
        }
    }

    private void OnDisable()
    {
        foreach (GameEventReponse lR in GameEvent_Responses)
        {
            lR.GameEvent.UnRegisterListener(this);
        }
    }

    //when an event is raised check which event it is and then invoke the response tied to it
    public void OnEventRaised(GameEvent gameEvent)
    {
        foreach (GameEventReponse lR in GameEvent_Responses)
        {
            if (lR.GameEvent == gameEvent)
            lR.Response.Invoke();
        }
    }
}
