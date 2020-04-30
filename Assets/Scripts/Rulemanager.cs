using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class Rulemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Showwin = null; // Textオブジェクト
    public GameObject ShowwinBG;
    Text win;
    public bool Battleend = false; 
    void Start()
    {
        ShowwinBG.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //引き分け判定
        if (Turnmanager.turn == 9)
        {

            win = Showwin.GetComponent<Text>();
            ShowwinBG.SetActive(true);
            win.text = "Draw...";
            Battleend = true;
        }
        //勝ち判定
        if (Clickmanager.state[0] == Clickmanager.state[1]&& Clickmanager.state[0] == Clickmanager.state[2]&& Clickmanager.state[0] !=0)
        {
            Winmgr();
        }
        if (Clickmanager.state[3] == Clickmanager.state[4] && Clickmanager.state[3] == Clickmanager.state[5] && Clickmanager.state[3] != 0)
        {
            Winmgr();
        }
        if (Clickmanager.state[6] == Clickmanager.state[7] && Clickmanager.state[6] == Clickmanager.state[8] && Clickmanager.state[6] != 0)
        {
            Winmgr();
        }
        //ここまで横列
        if (Clickmanager.state[0] == Clickmanager.state[3] && Clickmanager.state[0] == Clickmanager.state[6] && Clickmanager.state[0] != 0)
        {
            Winmgr();
        }
        if (Clickmanager.state[1] == Clickmanager.state[4] && Clickmanager.state[1] == Clickmanager.state[7] && Clickmanager.state[1] != 0)
        {
            Winmgr();
        }
        if (Clickmanager.state[2] == Clickmanager.state[5] && Clickmanager.state[2] == Clickmanager.state[8] && Clickmanager.state[2] != 0)
        {
            Winmgr();
        }
        //ここまで縦列
        if (Clickmanager.state[0] == Clickmanager.state[4] && Clickmanager.state[0] == Clickmanager.state[8] && Clickmanager.state[0] != 0)
        {
            Winmgr();
        }
        if (Clickmanager.state[2] == Clickmanager.state[4] && Clickmanager.state[2] == Clickmanager.state[6] && Clickmanager.state[2] != 0)
        {
            Winmgr();
        }
        //ななめ



    }
    public void Winmgr() {
        //どちらかが勝った時
        Battleend = true;
        ShowwinBG.SetActive(true);
        win = Showwin.GetComponent<Text>();
        if (Turnmanager.turn %2== 1)
        {
            win.text = "WINNER:〇";
        }
        else {
            win.text = "WINNER:×";
        }
        int i;//for文
        for (i = 0; i < 9; i++)
        {
           
            Clickmanager.state[i] = 2;//これ以上の変更を無効に

        }

    }
   
}
