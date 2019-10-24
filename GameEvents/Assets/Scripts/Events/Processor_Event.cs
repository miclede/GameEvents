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

    public void GetReward(Character character, GameEvent gameEvent)
    {
        CharEvent.Character = character;

        CharEvent.GameEvent = gameEvent;

        SendReward(CharEvent.Character, CharEvent.GameEvent);
    }

    void SendReward(Character character, GameEvent gameEvent)
    {
        for (int i = 0; i < RewardDictionary.Rewards.Count; i++)
        {
            if(RewardDictionary.Rewards[i].GameEvent == gameEvent)
            {
                RewardDictionary.Rewards[i].RewardCharacter(character);
            }
        }
    }
}
