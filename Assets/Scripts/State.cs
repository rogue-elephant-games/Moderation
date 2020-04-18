using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "state")]
public class State : ScriptableObject
{
    [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStateStory() => storyText;

    public State[] GetNextStates() => nextStates;
}
