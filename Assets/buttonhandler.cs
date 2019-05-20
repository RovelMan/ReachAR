using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonhandler : MonoBehaviour
{
    public void closePanel()
    {
        GameObject.Find("Panel").SetActive(false);
    }
}
