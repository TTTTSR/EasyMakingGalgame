using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BGMChangeEvent : Event
{
    public AudioClip BGM;
    public override void Act(GameScripts game)
    {
        game.setBGM(BGM);
    }
}