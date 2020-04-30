using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turnmanager : MonoBehaviour
{
    public static int turn;
    public GameObject Showturn = null; // Textオブジェクト
    Text nowturn;
    // Start is called before the first frame update
    void Start()
    {
        turn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        nowturn = Showturn.GetComponent<Text>();
        if (Turnmanager.turn % 2 == 0)
        {
            nowturn.text = "〇";
        }
        else
        {
            nowturn.text = "×";
        }
    }
}
