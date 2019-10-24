using UnityEngine;

[CreateAssetMenu(fileName = "Event Processor", menuName = "Events/Processor")]
public class Processor_Event : ScriptableObject
{
    [SerializeField]
    private EventRewardDictionary rewardDictionary = default;
    public EventRewardDictionary RewardDictionary => rewardDictionary;


}
