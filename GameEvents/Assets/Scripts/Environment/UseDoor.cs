using UnityEngine;

//simulate something happening related to events
//open and close a door while triggering pay events
//press E on keyboard to open, close, and recieve 1 / 5 currency
public class UseDoor : MonoBehaviour
{
    private bool DoorStatus;

    //events to raise filled in inspector
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
