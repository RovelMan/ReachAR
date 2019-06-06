using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goalBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject resetButton;
    private GameObject WinPanel;
    private resetButtonHandler resetHandler;
    private string SceneName;
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

    private int levelRating()
    {
        GameObject UserWalls = GameObject.Find("UserWalls");
        GameObject gameplane = GameObject.Find("naturePack_001");

        float x_1 = gameplane.transform.localScale.x*UserWalls.transform.localScale.x;
        float x_0 = -x_1;
        float z_1 = gameplane.transform.localScale.z*UserWalls.transform.localScale.z;
        float z_0 = -z_1;
        int score = 4;
        foreach (Transform child in UserWalls.transform)
        {
            if ((x_0 < child.position.x && child.position.x < x_1) && (z_0 < child.position.z && child.position.z < z_1))
            {
                score--;
            }
        }

        if (score <= 0) {
            score = 1;
        }

        Debug.Log("Score:" + score.ToString());
        return score;
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
            case "Level3":
                stageLevel = 3;
                break;
            default:
                stageLevel = 1;
                break;
        }
        int currentLevel = PlayerPrefs.GetInt("currentLevel");
        if (currentLevel < stageLevel) {
            PlayerPrefs.SetInt("currentLevel", stageLevel);
        }
        int score = levelRating();
        if (score > PlayerPrefs.GetInt(SceneName))
        {
            PlayerPrefs.SetInt(SceneName, score);
        }
        WinPanel.GetComponentInChildren<Text>().text += score.ToString() + '.';
        WinPanel.SetActive(true);

        resetHandler.resetBall();

    }
}
