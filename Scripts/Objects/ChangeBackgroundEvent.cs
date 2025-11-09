using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChangeBackgroundEvent : Event
{
    public override void Act(GameScripts game)
    {
        
        game.ChangeBackground(Value);
    }
}