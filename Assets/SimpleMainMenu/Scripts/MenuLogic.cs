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

    public void PlayStage(string stageName)
    {
        SceneManager.LoadScene(stageName, LoadSceneMode.Single);
    }
}
