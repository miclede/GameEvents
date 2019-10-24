using UnityEngine;

public class ItemReward : EventReward
{
    [SerializeField]
    private float amount = default;
    public float Amount => amount;

    public override void RewardCharacter(Character character)
    {
        character.AddCurrency(amount);
        Debug.Log("Character was rewarded: " + amount);
    }
}