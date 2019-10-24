using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//This will hold the rewards for a set of events
[CreateAssetMenu(fileName = "Event Rewards Dictionary", menuName = "Events/EventRewardsDictionary")]
public class EventRewardDictionary : ScriptableObject
{
    public List<EventReward> Rewards = new List<EventReward>();

//Stuff for adding and maintaining the Rewards List of EventRewards
#if UNITY_EDITOR
    public void Add(EventReward reward)
    {
        Rewards.Add(reward);
        CleanList();
        Save();
    }

    void CleanList()
    {
        Rewards = Rewards.Distinct().ToList();
        Rewards = Rewards.Where(EventReward => EventReward != null).ToList();
    }

    void Save()
    {
        UnityEditor.EditorUtility.SetDirty(this);
        UnityEditor.AssetDatabase.SaveAssets();
        UnityEditor.AssetDatabase.Refresh();
    }
#endif
}
