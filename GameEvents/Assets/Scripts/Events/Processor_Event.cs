using UnityEngine;

[CreateAssetMenu(fileName = "Event Processor", menuName = "Events/Processor")]
public class Processor_Event : ScriptableObject
{
    [SerializeField]
    private EventRewardDictionary rewardDictionary = default;
    public EventRewardDictionary RewardDictionary => rewardDictionary;

    struct CharacterEvent
    {
        public Character Character;

        public GameEvent GameEvent;
    }

    CharacterEvent CharEvent = new CharacterEvent();

    public void GetReward(GameEventListener listener)
    {
        CharEvent.Character = listener.GetComponentInParent<Character>();

        CharEvent.GameEvent = listener.GameEvent;

        sendReward(CharEvent.Character, CharEvent.GameEvent);
    }

    void sendReward(Character character, GameEvent gameEvent)
    {
        for (int i = 0; i < rewardDictionary.Rewards.Count; i++)
        {
            if(rewardDictionary.Rewards[i].GameEvent == gameEvent)
            {
                rewardDictionary.Rewards[i].RewardCharacter(character);
            }
        }
    }
}
