using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject resetButton;
    private resetButtonHandler resetHandler;
    void Start()
    {
        resetButton = GameObject.Find("ResetButton");
        resetHandler = (resetButtonHandler) resetButton.GetComponent(typeof(resetButtonHandler));
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("hei");
        resetHandler.resetBall();
    }
}
