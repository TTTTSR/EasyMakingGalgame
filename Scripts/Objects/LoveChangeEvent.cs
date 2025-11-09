using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LoveChangeEvent : Event
{
    public int LoveChange;
    public override void Act(GameScripts game)
    {
        AutoNext = true;
        GameManage.Charactors[Value].love += LoveChange;
    }
}