using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Titlemanager : MonoBehaviour

{
    public void OnClick() { 
    SceneManager.LoadScene("Mainmode");
    }
}