using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField]
    private GameEvent gameEvent;
    public GameEvent GameEvent => gameEvent;

    public UnityEvent Response;

    private void OnEnable()
    {
        GameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        GameEvent.UnRegisterListener(this);
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }
}
