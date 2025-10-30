using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Detect collision with another object
    private void OnCollisionEnter(Collision collision)
    {
        //Check if the object has an AudioSource component
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            //play the sound  
            audioSource.Play(); 

        }
    }
}
