using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InitialLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        initStageProgress();
        initLevelRatings();
        Debug.Log(PlayerPrefs.GetInt("currentLevel"));
    }

    private void initStageProgress()
    {
        if (!PlayerPrefs.HasKey("currentLevel"))
        {
            PlayerPrefs.SetInt("currentLevel", 0);
        }
    }

    private void initLevelRatings()
    {
        int sceneCount = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
        for( int i = 0; i < sceneCount; i++ )
        {
            string levelName = System.IO.Path.GetFileNameWithoutExtension( UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex( i ) );
            if (!PlayerPrefs.HasKey(levelName))
            {
                PlayerPrefs.SetInt(levelName, 0);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
