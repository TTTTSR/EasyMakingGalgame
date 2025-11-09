using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChooseEvent : Event
{
    public List<string> choices = new List<string>();
    public List<Event> benchs = new List<Event>();
    public override void Act(GameScripts game)
    {
        Dictionary<string, Event> Choices = new Dictionary<string, Event>();
        for (int i = 0; i < choices.Count; i++)
        {
            Choices.Add(choices[i], benchs[i]);
        }
        game.ShowChoice(Choices);
    }
}
