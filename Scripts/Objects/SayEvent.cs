using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SayEvent : Event
{
    public override void Act(GameScripts game)
    {
        string[] con = Value.Split('^');
        game.SayLine(con[0], con[1]);
    }
}



