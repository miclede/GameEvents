using UnityEngine;

//EventReward Disctionary has a list of these
//Other rewards will inherit from this ie. Item, Experience, Money, Repuation
public abstract class EventReward : ScriptableObject
{
    [SerializeField]
    private GameEvent gameEvent = default;
    public GameEvent GameEvent => gameEvent;

    public virtual void RewardCharacter(Character character)
    {    }

//add to rewards dictionary through context menu instead of dragging in
#if UNITY_EDITOR
    [ContextMenu("Add To Rewards Dictionary")]
    void AddToRewards()
    {
        EventRewardDictionary rewardDictionary =
            (EventRewardDictionary)UnityEditor.AssetDatabase.LoadAssetAtPath
            ("Assets/ScriptableObjects/Events/Event Rewards Dictionary.asset", typeof(EventRewardDictionary));

        if (rewardDictionary != null)
            rewardDictionary.Add(this);
    }
#endif
}
