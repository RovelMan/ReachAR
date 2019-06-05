using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuLogic : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject Menu;
    private GameObject StageMenu;
    void Start()
    {
        Menu = GameObject.Find("Menu");
        StageMenu = GameObject.Find("StageMenu");
        StageMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuSelect() 
    {
        Menu.SetActive(true);
        StageMenu.SetActive(false);
    }
    
    public void StageSelect() 
    {
        StageMenu.SetActive(true);
        Menu.SetActive(false);
    }

    public void PlayStage(int stage)
    {
        switch(stage){
            case 1:
                SceneManager.LoadScene("Level1", LoadSceneMode.Single);
                break;
            case 2:
                Debug.Log("Shoud load level 2");
                break;
            case 3:
                Debug.Log("Should load level 3");
                break;
            default:
                Debug.Log("default option");
                break;
        }
    }
}
