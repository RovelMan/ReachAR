using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MoveLeftOnClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    private GameObject ControlCanvas;
    private WallControl script;
    private bool ispressed = false;
    void Start()
    {
        ControlCanvas = GameObject.Find("ControlCanvas");
        script = (WallControl) ControlCanvas.GetComponent(typeof(WallControl));
    }

    // Update is called once per frame
    void Update()
    {
        if (!ispressed){
            return;
        }
        Vector3 positionInc = new Vector3(-0.01f, 0f, 0f);
        script.MoveWall(positionInc);
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
