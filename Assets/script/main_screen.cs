using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class main_screen : MonoBehaviour
{
    [SerializeField]
   private string abs1 = "Start_Scene";
    public void PlayGame()
    {
        Debug.Log("button pressed/");
        SceneManager.LoadScene(abs1);
    }
}
