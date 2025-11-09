using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SwitchEvent : Event
{
    public int LoveLine;
    Event Suceess;
    Event Lose;
    public override void Act(GameScripts game)
    {
        AutoNext = true;
        if (GameManage.Charactors[Value].love > LoveLine)
        {
            Suceess.Act(game);
        }
        else
        {
            Lose.Act(game);
        }
    }
}