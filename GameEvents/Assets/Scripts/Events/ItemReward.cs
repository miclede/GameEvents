using UnityEngine;

//this inherits from EventReward so it can be added to the EventRewardDictionary
[CreateAssetMenu(menuName = "Rewards/ItemReward")]
public class ItemReward : EventReward
{
    [SerializeField]
    private float amount = default;
    public float Amount => amount;

    //Add the amount tied to the reward to a Character
    public override void RewardCharacter(Character character)
    {
        character.AddCurrency(Amount);
        Debug.Log("Character was awarded: " + Amount);
        Debug.Log("Character has a total of: " + character.Currency + " Currency.");
    }
}