using UnityEngine;

//used for this example to raise events with the E key
public class RaiseOnInteract : MonoBehaviour
{
    [SerializeField]
    private GameEvent gameEvent = default;
    public GameEvent GameEvent => gameEvent;

    public void InteractEvent()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameEvent.Raise();  
        }
    }

    private void Update()
    {
        InteractEvent();
    }
}
