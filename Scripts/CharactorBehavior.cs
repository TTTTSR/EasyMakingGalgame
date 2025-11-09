using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorBehavior : MonoBehaviour
{
    public Charactor Data;
    public void RecieveData(Charactor data)
    {
        Data = data;
        GetComponent<SpriteRenderer>().sprite = data.sprite;
    }
}
