using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject resetButton;
    private GameObject WinPanel;
    private resetButtonHandler resetHandler;
    void Start()
    {
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
        int currentLevel = PlayerPrefs.GetInt("currentLevel");
        if (currentLevel < 1) {
            PlayerPrefs.SetInt("currentLevel", 1);
        }
        WinPanel.SetActive(true);

        resetHandler.resetBall();

    }
}
