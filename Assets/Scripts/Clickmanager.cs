using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
//using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ClickManager : MonoBehaviour
{
    public int place;
    //1 2 3
    //4 5 6
    //7 8 9
    public GameObject masu = null;
    public static int[] MBstate = new int[9];// スコア変数,×→-1,〇→1,無印→0;
    public static Text[] MBmark = new Text[9];
    // 初期化
    void Start()
    {
        int i;
        for (i = 0; i < 9; i++)
        {
            MBstate[i] = 0;
        }
    }

    void OnMouseDown()
    {
        putMBmark();
        //var objectofRuleManager =new RuleManager();
        //objectofRuleManager.judge();
    }

    void putMBmark()
    {
        int i;//for文
        for (i = 0; i < 9; i++)
        {
            MBmark[i] = masu.GetComponent<Text>();

        }
        if (MBstate[place - 1] != 0)
        {
            //すでにマークされてる場合を除外
        }
        else if (RuleManager.turn % 2 == 1)
        {
            MBmark[place - 1].text = "×";
            MBstate[place - 1] = -1;
            RuleManager.turn++;
        }
        else
        {
            MBmark[place - 1].text = "〇";
            MBstate[place - 1] = 1;
            RuleManager.turn++;
        }
    }
}