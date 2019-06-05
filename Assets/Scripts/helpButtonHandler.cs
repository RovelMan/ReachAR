using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpButtonHandler : MonoBehaviour
{

    private GameObject tutorialPanel;

    void Start()
    {
        tutorialPanel = GameObject.Find("Panel");
    }

    public void openPanel()
    {
        tutorialPanel.SetActive(true);
    }
}
