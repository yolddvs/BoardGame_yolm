using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    public AudioClip explosionSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //detect collision with Target
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("Ball hit the Target!");

            //Load next scene in 2 seconds (so that the sound can play)
            Invoke("LoadNextScene", 2f);

        }
        if (collision.gameObject.CompareTag("BallLost"))
{
    Debug.Log("Ball is lost");

    // stop further collisions so the sound only happens once
    GetComponent<Collider>().enabled = false; 
    GetComponent<Rigidbody>().isKinematic = true;

    //Reload current scene in 2 seconds (so that the sound can play)
    Invoke("ReloadScene", 2f);
}

        if (collision.gameObject.CompareTag("DestroyFoe"))
        {
            Debug.Log("Ball is destroyed by the foe");

            //Disable the renderer and collider
            GetComponent<Renderer>().enabled = false;

            //set the ball as kinematic so that it stops moving
            GetComponent<Rigidbody>().isKinematic = true;

    //play the explosion sound
    if (explosionSound != null)
            {
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);
            }

            //Reload current scene in 2 seconds (so that the sound can play)
            Invoke("ReloadScene", 2f);
        }
    }


    private void ReloadScene()
    {
        //Reload current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void LoadNextScene()
    {
        //Load next scene or the first scene if there is no next scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
