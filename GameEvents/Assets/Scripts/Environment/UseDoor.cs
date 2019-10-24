using UnityEngine;

public class UseDoor : MonoBehaviour
{
    private bool DoorStatus;

    public GameEvent AEvent;
    public GameEvent BEvent;

    public void UsedDoor()
    {
        if (!DoorStatus)
        {
            DoorStatus = true;
            Debug.Log("The Door was Opened.");
            AEvent.Raise();
        }

        else if (DoorStatus)
        {
            DoorStatus = false;
            Debug.Log("The Door was Closed.");
            BEvent.Raise();
        }
    }

    private void Start()
    {
        DoorStatus = false;
    }
}
