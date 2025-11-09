using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CGPlayEvent : Event
{
    public override void Act(GameScripts game)
    {
        game.CGPlay(Value);
    }
}