using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject resetButton;
    private GameObject WinPanel;
    private resetButtonHandler resetHandler;
    private string SceneName;
    private 
    void Start()
    {
        
        SceneName = SceneManager.GetActiveScene().name;
        resetButton = GameObject.Find("ResetButton");
        resetHandler = (resetButtonHandler) resetButton.GetComponent(typeof(resetButtonHandler));
        WinPanel = GameObject.FindWithTag("WinPanel");
        WinPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        MeshRenderer meshRend = GetComponent<MeshRenderer>();
        meshRend.material.color = Color.green;
        int stageLevel = 0;
        switch(SceneName)
        {
            case "Level1":
                stageLevel = 1;
                break;
            case "Level2":
                stageLevel = 2;
                break;
            default:
                stageLevel = 1;
                break;
        }
        int currentLevel = PlayerPrefs.GetInt("currentLevel");
        if (currentLevel < stageLevel) {
            PlayerPrefs.SetInt("currentLevel", stageLevel);
        }
        WinPanel.SetActive(true);

        resetHandler.resetBall();

    }
}
