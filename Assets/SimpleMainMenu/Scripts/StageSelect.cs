using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StageSelect : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject MenuCanvas;
    private MenuLogic script;

    private string stageName;
    void Start()
    {
        MenuCanvas = GameObject.Find("MenuCanvas");
        script = (MenuLogic) MenuCanvas.GetComponent(typeof(MenuLogic));

        switch(gameObject.name)
        {
            case "Stage1Button":
                stageName = "Level1";
                break;
            case "Stage2Button":
                stageName = "Level2";
                break;
            case "Stage3Button":
                stageName = "Level3";
                break;
            default:
                Debug.LogError("Stage Button Name Error:" + gameObject.name);
                break;
        }

        gameObject.GetComponentInChildren<Text>().text += GetStageRating();

    }

    private string GetStageRating()
    {
        string stars = "";
        int rating = PlayerPrefs.GetInt(stageName);
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
        script.PlayStage(stageName);
    }
}
