using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RotateLeftOnClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    private GameObject ControlCanvas;
    private WallControl script;
    private bool ispressed = false;
    void Start()
    {
        ControlCanvas = GameObject.Find("ControlCanvas");
        script = (WallControl) ControlCanvas.GetComponent(typeof(WallControl));

        Debug.Log("Should Rotate Init");
    }

    // Update is called once per frame
    void Update()
    {
        if (!ispressed){
            return;
        }
        Quaternion rotationInc = Quaternion.Euler(0f, -2f, 0f);
        script.RotateWall(rotationInc);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }
 
    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
