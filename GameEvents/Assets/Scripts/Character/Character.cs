using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private float currency = default;
    public float Currency => currency;

    //normally put this in a processor but for this example I'll leave it here
    public void AddCurrency(float quantity)
    {
        currency += quantity;
    }
}
