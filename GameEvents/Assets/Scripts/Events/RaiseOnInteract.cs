using UnityEngine;

public class RaiseOnInteract : MonoBehaviour
{
    [SerializeField]
    private GameEvent gameEvent = default;
    public GameEvent GameEvent => gameEvent;

    public void InteractEvent()
    {
        if (Input.GetKey(KeyCode.E))
        {
            GameEvent.Raise();
        }
    }
}
