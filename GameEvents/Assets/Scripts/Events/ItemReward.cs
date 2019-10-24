using UnityEngine;

[CreateAssetMenu(menuName = "Rewards/ItemReward")]
public class ItemReward : EventReward
{
    [SerializeField]
    private float amount = default;
    public float Amount => amount;

    public override void RewardCharacter(Character character)
    {
        character.AddCurrency(Amount);
        Debug.Log("Character was rewarded: " + Amount);
    }
}