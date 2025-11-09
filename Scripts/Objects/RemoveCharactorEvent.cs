using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class RemoveCharactorEvent : Event
{
    public override void Act(GameScripts game)
    {
        game.RemoveCharactor(Value);
    }
}
