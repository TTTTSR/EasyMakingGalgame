using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choices : MonoBehaviour
{
    public GameObject choicebutton;
    public void Clear()
    {
        for (int i =0; i<transform.childCount;i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
    public void Show( Dictionary<string,Event> choices)
    {
        Clear();
        int number = choices.Count;
        int index = 0;
        foreach (string Choice in choices.Keys)
        {
            GameObject button = Instantiate(choicebutton);
            button.GetComponentInChildren<Text>().text = Choice;
            button.GetComponent<Button>().onClick.AddListener(delegate {
                GameObject.Find("GameManager").GetComponent<GameScripts>().events.Insert(GameObject.Find("GameManager").GetComponent<GameScripts>().RunningIndex + 1, choices[Choice]);
                GameManage.Next();Clear(); });
            button.GetComponent<RectTransform>().SetParent( GetComponent<RectTransform>());
            button.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 100 - 120 * (number - 1) / 2 + 120 * index);
            button.GetComponent<RectTransform>().localScale = new Vector2(1, 1);
            index++;
        }
    }
}
