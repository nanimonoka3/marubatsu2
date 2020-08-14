using Script;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    public Text[] iconText;
    public Text resultText;
    public Text nextPlayerText;
    public GameObject resultBG;
    private RuleManager _ruleManager;

    void Start()
    {
        _ruleManager = new RuleManager();

        int i;
        for (i = 0; i < 9; i++)
        {
            _ruleManager.PutState(i,0);
            iconText[i].text = "";
        }
    }
    public void OnSelect(int index)
    {
        if (GetCellIconState(index) == 0)
        {
            PutIconText(index);
            if (_ruleManager.Judge() != 0)
            {
                WinManager();
            }
        }
        else {
            Debug.Log("already marked!!");
        }
       
    }
    private int GetCellIconState(int index)
    {
        return RuleManager.IconState[index];
    }
    private void PutIconText(int index)
    {
        _ruleManager.PutIconState(index);
        if (_ruleManager.MaruTurn() == true)
        {
            iconText[index].text = "×";
            nextPlayerText.text = "〇";
        }
        else
        {
            iconText[index].text = "〇";
            nextPlayerText.text = "×";    
        }
        _ruleManager.AddTurn();
    }
    private void WinManager()
    {
        if (_ruleManager.Judge() == -1)
        {
            resultText.text = "DRAW";
        }
        else if (_ruleManager.Judge() % 2 == 1)
        {
            resultText.text = "WINNER:〇";
        }
        else
        {
            resultText.text = "WINNER:×";
        }
        resultBG.SetActive(true);
        int i;//for文
        for (i = 0; i < 9; i++)
        {
            _ruleManager.PutState(i,2);
        }
    }
}