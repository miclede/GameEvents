using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private bool DoorStatus;

    public void OpenedDoor()
    {
        if (!DoorStatus)
        Debug.Log("The Door was Opened");
    }

    private void Awake()
    {
        DoorStatus = false;
    }
}
