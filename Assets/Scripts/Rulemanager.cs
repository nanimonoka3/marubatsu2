using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class RuleManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Showwin = null;
    public GameObject ShowwinBG;
    Text win;
    public bool Battleend = false;
    public static int turn;
    public GameObject Showturn = null;
    Text nowturn;
    void Start()
    {
        ShowwinBG.SetActive(false);
        turn = 0;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shownowturn();
            judge();
        }
    }
    public void shownowturn()
    {
        nowturn = Showturn.GetComponent<Text>();
        if (turn % 2 == 0)
        {
            nowturn.text = "〇";
        }
        else
        {
            nowturn.text = "×";
        }
    }
    public void judge()
    {
        //引き分け判定
        if (turn == 9)
        {

            win = Showwin.GetComponent<Text>();
            ShowwinBG.SetActive(true);
            if (Battleend == false)
            {
                win.text = "Draw...";
            }
            Battleend = true;
        }
        //勝ち判定
        if (ClickManager.MBstate[0] == ClickManager.MBstate[1] && ClickManager.MBstate[0] == ClickManager.MBstate[2])
        {
            Winmgr(ClickManager.MBstate[0]);
        }
        if (ClickManager.MBstate[3] == ClickManager.MBstate[4] && ClickManager.MBstate[3] == ClickManager.MBstate[5])
        {
            Winmgr(ClickManager.MBstate[3]);
        }
        if (ClickManager.MBstate[6] == ClickManager.MBstate[7] && ClickManager.MBstate[6] == ClickManager.MBstate[8])
        {
            Winmgr(ClickManager.MBstate[6]);
        }
        //ここまで横列
        if (ClickManager.MBstate[0] == ClickManager.MBstate[3] && ClickManager.MBstate[0] == ClickManager.MBstate[6])
        {
            Winmgr(ClickManager.MBstate[0]);
        }
        if (ClickManager.MBstate[1] == ClickManager.MBstate[4] && ClickManager.MBstate[1] == ClickManager.MBstate[7])
        {
            Winmgr(ClickManager.MBstate[1]);
        }
        if (ClickManager.MBstate[2] == ClickManager.MBstate[5] && ClickManager.MBstate[2] == ClickManager.MBstate[8])
        {
            Winmgr(ClickManager.MBstate[2]);
        }
        //ここまで縦列
        if (ClickManager.MBstate[0] == ClickManager.MBstate[4] && ClickManager.MBstate[0] == ClickManager.MBstate[8])
        {
            Winmgr(ClickManager.MBstate[0]);
        }
        if (ClickManager.MBstate[2] == ClickManager.MBstate[4] && ClickManager.MBstate[2] == ClickManager.MBstate[6])
        {
            Winmgr(ClickManager.MBstate[2]);
        }
        //ななめ
    }
    void Winmgr(int winnerMBstate)
    {
        //どちらかが勝った時
        //Battleend = true;
        if (winnerMBstate != 0)
        {
            ShowwinBG.SetActive(true);
            win = Showwin.GetComponent<Text>();
            if (winnerMBstate == 1)
            {
                win.text = "WINNER:〇";
            }
            else if (winnerMBstate == -1)
            {
                win.text = "WINNER:×";
            }
            int i;//for文
            for (i = 0; i < 9; i++)
            {
                ClickManager.MBstate[i] = 2;//これ以上の変更を無効に
            }
            Battleend = true;
        }

    }

}
