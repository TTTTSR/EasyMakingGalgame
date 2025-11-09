using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ContinuesayEvent : Event
{
    public override void Act(GameScripts game)
    {
        game.ContinueSay(Value);
    }
}