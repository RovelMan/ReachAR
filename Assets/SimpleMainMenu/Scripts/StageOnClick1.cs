using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageOnClick1 : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject MenuCanvas;
    private MenuLogic script;
    void Start()
    {
        MenuCanvas = GameObject.Find("MenuCanvas");
        script = (MenuLogic) MenuCanvas.GetComponent(typeof(MenuLogic));

        GameObject.Find("Stage1Button").GetComponentInChildren<Text>().text += GetStageRating();
    }

    private string GetStageRating()
    {
        string stars = "";
        int rating = PlayerPrefs.GetInt("Level1");
        for (int i = 0; i < rating; i++)
        {
            stars += " *";
        }
        return stars;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayStage()
    {
        script.PlayStage(1);
    }
}
