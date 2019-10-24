using UnityEngine;

public abstract class EventReward : ScriptableObject
{
    [SerializeField]
    private GameEvent gameEvent = default;
    public GameEvent GameEvent => gameEvent;

    public virtual void RewardCharacter(Character character)
    {    }

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
