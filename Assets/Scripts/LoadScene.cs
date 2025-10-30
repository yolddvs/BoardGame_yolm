using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadNextScene()
    {
        //load next scene or the first scene if the current scene is the last one
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    //load a scene by its name
    public void LoadByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
