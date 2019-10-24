using UnityEngine;

public class UseDoor : MonoBehaviour
{
    private bool DoorStatus;

    public void UsedDoor()
    {
        if (!DoorStatus)
        {
            DoorStatus = true;
            Debug.Log("The Door was Opened.");
        }

        else if (DoorStatus)
        {
            DoorStatus = false;
            Debug.Log("The Door was Closed.");
        }
    }

    private void Start()
    {
        DoorStatus = false;
    }
}
