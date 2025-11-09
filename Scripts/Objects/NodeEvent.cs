using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class NodeEvent : Event
{
    List<Event> events = new List<Event>();
    public override void Act(GameScripts game)
    {
        AutoNext = true;
        game.events.InsertRange(game.RunningIndex, events);
    }
}

