using UnityEngine;

//Simulate a character
public class Character : MonoBehaviour
{
    [SerializeField]
    private float currency = default;
    public float Currency => currency;

    //not good practice to have this here but its just an example
    //AddCurrency called from an ItemReward ScriptableObject
    public void AddCurrency(float quantity)
    {
        currency += quantity;
    }
}
