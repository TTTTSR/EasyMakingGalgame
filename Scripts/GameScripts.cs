using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using UnityEngine.UI;

public class GameScripts : MonoBehaviour
{
    
    public Choices Choices;
    public Charactors Charactors;
    public Image BackGround;
    public Sprite CGBgTemp;
    public AudioSource bgm;
    public Dictionary<string,CharactorBehavior> CharactorInstance = new Dictionary<string, CharactorBehavior> ();
    public List<Event> events = new List<Event> ();
    public Text Saying;
    public Text Speaker;
    public bool next =false;
    public bool Choosing =false;
    public int RunningIndex=0;
    void Start()
    {
        Charactors.Sort();
        GameManage.LoadData();
        StartCoroutine("gamerun");
    }

    // Update is called once per frame
    void Update()
    {
        if (!Choosing)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Next();
            }
        }
    }
    IEnumerator gamerun()
    {
        for (int i = 0;i<events.Count;i++)
        {
            Debug.Log(i);
            RunningIndex = i;
            Event eventtodo = events[i];
            eventtodo.Act(this);
            if (eventtodo.clip!=null)
            {
                GetComponent<AudioSource>().clip = eventtodo.clip;
                GetComponent<AudioSource>().Play();
            }

            if (!eventtodo.AutoNext)
            {
                yield return new WaitUntil(() => { return next; });
                next = false;
            }
        }
        
    }
    public void ChangeBackground(string Name)
    {
        Sprite Backgroundsp = GameManage.GetBackground(Name);
        BackGround.sprite = Backgroundsp;
    }
    public void AddCharactor(string Name)
    {
        CharactorBehavior ins = Charactors.GetComponent<Charactors>().AddCharactor(GameManage.GetCharactor(Name));
        CharactorInstance.Add(Name,ins);
    }
    public void RemoveCharactor(string Name)
    {
        Charactors.RemoveCharactor(CharactorInstance[Name]);
        CharactorInstance.Remove(Name);
    }
    public void SayLine(string Name , string Content)
    {
        Speaker.text = Name;
        Saying.text = Content;
    }
    public void ContinueSay(string Content)
    {
        Saying.text += Content;
    }
    public void ShowChoice(Dictionary<string,Event> choices)
    {
        Choosing = true;
        Choices.Show( choices);
    }
    public void CGPlay(string Name)
    {
        Sprite cg = GameManage.GetCG(Name);
        Charactors.gameObject.SetActive(false);
        Speaker.gameObject.SetActive(false);
        Saying.gameObject.SetActive(false);
        CGBgTemp = BackGround.sprite;
        BackGround.sprite = cg;
    }
    public void Next()
    {
        if (next == false)
        {
            next = true;
        }
        Charactors.gameObject.SetActive(true);
        Speaker.gameObject.SetActive(true);
        Saying.gameObject.SetActive(true);
        if (CGBgTemp!=null)
        {
            BackGround.sprite = CGBgTemp;
        }
    }
    public void setBGM(AudioClip clip)
    {
        bgm.clip = clip;
    }
}
