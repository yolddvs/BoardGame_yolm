using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float forceMagnitude = 9f; // adjust this value to change the strength of the force


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //detect collision with Ball
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ball>() != null)
        {
            Debug.Log("Bumper hit the Ball!");

            //Add force to the ball in the direction of y axis of the bumper
            Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 forceDirection = transform.up; // y axis of the bumper
            ballRigidbody.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);


        }

    }
}
