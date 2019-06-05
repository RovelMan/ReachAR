using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("currentLevel"))
        {
            PlayerPrefs.SetInt("currentLevel", 0);
        }
        Debug.Log(PlayerPrefs.GetInt("currentLevel"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
