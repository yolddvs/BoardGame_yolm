using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadNextScene()
    {
        // Load next scene or loop to first scene if currently at the last one
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;

        SceneManager.LoadScene(nextSceneIndex);
    }

    // Load a scene by its name
    public void LoadByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
