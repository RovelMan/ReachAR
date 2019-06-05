using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonhandler : MonoBehaviour
{
    public void closeTutorialPanel()
    {
        // GetComponent<GameObject>().SetActive(false); 
        GameObject.Find("TutorialPanel").SetActive(false);
    }

    public void closeWinPanel() {

        GameObject.Find("WinPanel").SetActive(false);
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
