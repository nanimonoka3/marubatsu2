﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToTitle : MonoBehaviour
{
    public GameObject BTT_button;
    public void OnClick()
    {
        SceneManager.LoadScene("Title");
    }
}
