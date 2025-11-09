using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Event : ScriptableObject
{
    public bool AutoNext;
    public string Value;
    public AudioClip clip;
    public abstract void Act(GameScripts game);
}



