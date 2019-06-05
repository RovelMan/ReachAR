using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControl : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject Wall;
    private GameObject Board;
    void Start()
    {
        Wall = GameObject.Find("Wall1");   
        Board = GameObject.Find("Board");
    }

    public void SelectWall(int index)
    {
        switch(index)
        {
            case 1:
                Wall = GameObject.Find("Wall1");
                Debug.Log("Wall1 Selected");
                break;
            case 2:
                Wall = GameObject.Find("Wall2");
                Debug.Log("Wall2 Selected");
                break;
            case 3:
                Wall = GameObject.Find("Wall3");
                Debug.Log("Wall3 Selected");
                break;
            default:
                Wall = GameObject.Find("Wall1");
                break;
        }
    }
    public void MoveWall(Vector3 position)
    {
        Vector3 WallPosition = Wall.transform.position;
        WallPosition += position;
        WallPosition.y = Board.transform.position.y;
        Wall.transform.position = WallPosition;
    }
    public void RotateWall(Quaternion rotation)
    {
        Debug.Log(rotation);
        Quaternion WallRotation = Wall.transform.rotation;
        WallRotation.y += rotation.y;
        Wall.transform.rotation = WallRotation;
    }

    void Update()
    {

    }
}
