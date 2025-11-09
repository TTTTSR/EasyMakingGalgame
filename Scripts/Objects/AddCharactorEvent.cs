using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AddCharactorEvent : Event
{
    public override void Act(GameScripts game)
    {
        
        game.AddCharactor(Value);
    }
}
