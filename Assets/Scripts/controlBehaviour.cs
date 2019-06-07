using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class controlBehaviour : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    private GameObject ControlCanvas;
    private WallControl script;
    private bool ispressed = false;

    private Vector3 positionInc;
    private Quaternion rotationInc;

    private bool translate = true;

    void Start()
    {
        ControlCanvas = GameObject.Find("ControlCanvas");
        script = (WallControl) ControlCanvas.GetComponent(typeof(WallControl));
        float inc = 0.5f;
        float rotInc = 4f;
        switch(gameObject.name)
        {
            case "RightButton":
                positionInc = new Vector3(inc, 0f, 0f);
                break;
            case "LeftButton":
                positionInc = new Vector3(-inc, 0f, 0f);
                break;
            case "UpButton":
                positionInc = new Vector3(0f, 0f, inc);
                break;
            case "DownButton":
                positionInc = new Vector3(0f, 0f, -inc);
                break;
            case "RotateRightButton":
                rotationInc = Quaternion.Euler(0f, rotInc, 0f);
                translate = false;
                break;
            case "RotateLeftButton":
                rotationInc = Quaternion.Euler(0f, -rotInc, 0f);
                translate = false;
                break;
            default:
                Debug.LogError("Name on Button Error");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!ispressed){
            return;
        }
        if (translate) 
        {
            script.MoveWall(positionInc);
        } else
        {
            script.RotateWall(rotationInc);
        }
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