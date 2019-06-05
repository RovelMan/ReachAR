using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject MenuCanvas;
    private GameObject StageSelectCanvas;
    void Start()
    {
        MenuCanvas = GameObject.Find("MenuCanvas");
        StageSelectCanvas = GameObject.Find("StageSelectCanvas");
        StageSelectCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectStage() {
        StageSelectCanvas.SetActive(true);
        MenuCanvas.SetActive(false);
        // SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}
