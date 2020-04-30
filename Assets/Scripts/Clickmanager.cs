using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
//using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;  


public class Clickmanager : MonoBehaviour
{   
    public int place;
    public GameObject score_object = null; // Textオブジェクト
    public static int[] state = new int[9];// スコア変数
    public static Text[] Score_text=new Text[9];
    // 初期化
    void Start()
    {
        int i;
        for (i = 0; i < 9; i++) {
            state[i] = 0;
        }
    }
    public void OnMouseDown()
    {
        int i;//for文
        for (i = 0; i < 9; i++)
        {
            Score_text[i] = score_object.GetComponent<Text>();

        }
        if (state[place - 1] != 0)
        {
            //すでにマークされてる場合を除外
        }
        else if (Turnmanager.turn %2== 1) {
            Score_text[place - 1].text = "×";
            state[place - 1] = -1;
            Turnmanager.turn++;
        }
        else
        {
            Score_text[place - 1].text = "〇";
            state[place - 1] = 1;
            Turnmanager.turn++;
        }
        }
}