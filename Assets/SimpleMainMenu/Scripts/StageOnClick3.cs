using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageOnClick3 : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject MenuCanvas;
    private MenuLogic script;
    void Start()
    {
        MenuCanvas = GameObject.Find("MenuCanvas");
        script = (MenuLogic) MenuCanvas.GetComponent(typeof(MenuLogic));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayStage()
    {
        script.PlayStage(3);
    }
}
