using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnOnClick : MonoBehaviour
{
    // Start is called before the first frame u
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

    public void ReturnToMainMenu () {
        script.MenuSelect();
    }
}
