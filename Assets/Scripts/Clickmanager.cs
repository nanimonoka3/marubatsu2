using Script;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    public Text[] boardTexts;
    public Text Showwin;
    public Text Nextturn;
    public GameObject ShowwinBG;
    private RuleManager _ruleManager;

    void Start()
    {
        _ruleManager = new RuleManager();

        int i;
        for (i = 0; i < 9; i++)
        {
            RuleManager.MBstate[i] = 0;
            boardTexts[i].text = "";
        }
    }
    public void OnSelect(int index)
    {
        //Debug.Log(index);
        putMBmark(index);
    }
    public int GetCellMark(int index)
    {
        return RuleManager.MBstate[index];
    }
    private void putMBmark(int index)
    {

        if (GetCellMark(index) != 0)
        {
            Debug.Log("already marked!!");
            //すでにマークされてる場合を除外
        }
        else if (_ruleManager.maruturn() == true)//
        {
            RuleManager.MBstate[index] = -1;
            boardTexts[index].text = "×";
            Nextturn.text = "〇";
            _ruleManager.nextturn();
        }
        else
        {

            RuleManager.MBstate[index] = 1;
            boardTexts[index].text = "〇";
            Nextturn.text = "×";
            _ruleManager.nextturn();
        }
        if (_ruleManager.judge() != 0)
        {
            int winner;
            if (_ruleManager.judge() == -1)
            {
                winner = -1;
            }
            else
            {
                winner = _ruleManager.judge() % 2;
            }

            Winmgr(winner);
        }
    }
    public void Winmgr(int winner)
    {
        if (winner == -1)
        {
            Showwin.text = "DRAW";
        }
        else if (winner == 1)
        {
            Showwin.text = "WINNER:〇";
        }
        else
        {
            Showwin.text = "WINNER:×";
        }
        ShowwinBG.SetActive(true);
        int i;//for文
        for (i = 0; i < 9; i++)
        {
            RuleManager.MBstate[i] = 2;//これ以上の変更を無効に
        }
    }
}