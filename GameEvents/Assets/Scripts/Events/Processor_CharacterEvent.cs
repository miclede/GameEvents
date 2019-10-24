using UnityEngine;

//processor that will be tied to the UnityEvent in the inspector
[CreateAssetMenu(fileName = "Character Event Processor", menuName = "Events/CharacterEventProcessor")]
public class Processor_CharacterEvent : ScriptableObject
{
    [SerializeField]
    private EventRewardDictionary rewardDictionary = default;
    public EventRewardDictionary RewardDictionary => rewardDictionary;

    //store Character and GameEvent data
    struct CharacterEvent
    {
        public Character Character;

        public GameEvent GameEvent;
    }

    CharacterEvent CharEvent = new CharacterEvent();

    //this needs to be set to the Character that will recieve the reward
    public void getCharacter(Character character)
    {
        CharEvent.Character = character;
    }

    //this needs to be set to the GameEvent
    public void getGameEvent(GameEvent gameEvent)
    {
        CharEvent.GameEvent = gameEvent;
    }

    //sends the reward to the Character based on the GameEvent
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
