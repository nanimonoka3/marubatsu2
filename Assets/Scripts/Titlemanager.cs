using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour

{
    public void OnClick() { 
    SceneManager.LoadScene("Mainmode");
    }
}