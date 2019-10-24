using UnityEngine;

public abstract class EventReward : ScriptableObject
{
    [SerializeField]
    private GameEvent gameEvent;
    public GameEvent GameEvent => gameEvent;

    public virtual void RewardCharacter(Character character)
    {    }

#if UNITY_EDITOR
    [ContextMenu("Add To Rewards Dictionary")]
    void AddToRewards()
    {
        
    }
#endif
}
