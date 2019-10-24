using UnityEngine;

[CreateAssetMenu(fileName = "Character Event Processor", menuName = "Events/CharacterEventProcessor")]
public class Processor_CharacterEvent : ScriptableObject
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

    public void getCharacter(Character character)
    {
        CharEvent.Character = character;
    }

    public void getGameEvent(GameEvent gameEvent)
    {
        CharEvent.GameEvent = gameEvent;
    }

    public void SendReward()
    {
        for (int i = 0; i < RewardDictionary.Rewards.Count; i++)
        {
            if(RewardDictionary.Rewards[i].GameEvent == CharEvent.GameEvent)
            {
                RewardDictionary.Rewards[i].RewardCharacter(CharEvent.Character);
            }
        }
    }
}
