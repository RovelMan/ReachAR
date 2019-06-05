using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stages : MonoBehaviour
{
    // Start is called before the first frame update

    private int currentLevel;
    private Button[] stageButtons;
    void Start()
    {
        if (!PlayerPrefs.HasKey("currentLevel"))
        {
            currentLevel = 0;
        } else {
            currentLevel = PlayerPrefs.GetInt("currentLevel");
        }
        stageButtons = GetComponentsInChildren<Button>(true);
        int N_stages = stageButtons.Length - 1;
        for (int i = currentLevel + 1; i < N_stages; i++) 
        {
            stageButtons[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

}
