using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectWallOnDrop : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject ControlCanvas;
    private WallControl script;
    void Start()
    {
        ControlCanvas = GameObject.Find("ControlCanvas");
        script = (WallControl) ControlCanvas.GetComponent(typeof(WallControl));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnValueChanged(int change)
    {
        script.SelectWall(change + 1);
    }
}
