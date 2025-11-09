using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public static class GameManage
{
    public static Dictionary<string,Charactor> Charactors = new Dictionary<string,Charactor>();
    static Dictionary<string,Sprite> Backgrounds = new Dictionary<string,Sprite>();
    static Dictionary<string,Sprite> CGs = new Dictionary<string,Sprite>();
    public static GameObject GetCharactor(string Name)
    {
        GameObject cha = new GameObject("Name");
        cha.AddComponent<CharactorBehavior>();
        cha.AddComponent<SpriteRenderer>();
        cha.GetComponent<CharactorBehavior>().RecieveData(Charactors[Name]);
        return cha;
    }
    public static void LoadData()
    {
        foreach (Object ob in Resources.LoadAll("Charactors"))
        {
            Charactor cha = (Charactor)ob;
            Charactors.Add(cha.Name, cha);
        }
        foreach(Object ob in Resources.LoadAll("Background",typeof(BackgroundResource)))
        {
            BackgroundResource background = (BackgroundResource)ob;
            Backgrounds.Add(background.Name,background.Image);
        }
        foreach (Object ob in Resources.LoadAll("CG"))
        {
            CG cG = (CG)ob;
            CGs.Add(cG.Name,cG.CGImage);
        }
    }
    public static Sprite GetCG(string Name)
    {
        return CGs[Name];
    }
    public static Sprite GetBackground(string Name) { return Backgrounds[Name]; }
    public static void Next()
    {
        GameObject.Find("GameManager").GetComponent<GameScripts>().Next();
    }
   
}

