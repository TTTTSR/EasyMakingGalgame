using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactors : MonoBehaviour
{
    public void Sort()
    {
        float Width=6f;

        for(int i=0;i<transform.childCount;i++)
        {
            transform.GetChild(i).transform.position = new Vector3((-transform.childCount+1)*Width/2+i*Width,0,0); 
        }
    }
    public CharactorBehavior AddCharactor(GameObject chara)
    {
        chara.transform.parent = transform;
        Sort();
        return chara.GetComponent<CharactorBehavior>();
    }
    public void RemoveCharactor(CharactorBehavior charactorBehavior)
    {
        charactorBehavior.transform.parent = null;
        Destroy(charactorBehavior.gameObject);
    }
}
