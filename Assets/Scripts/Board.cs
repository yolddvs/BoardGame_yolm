using UnityEngine;
using UnityEngine.InputSystem;

public class Board : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Pointer.current != null)
        {
            //Vector2 pos = Pointer.current.position.ReadValue();
            //Debug.Log("Pointer position: " + pos);

            // rotate the board around x axis when the mouse moves up and down
            // and around z axis when the mouse moves left and right
            float rotationSpeed = 0.1f;
            float rotationX = Pointer.current.delta.y.ReadValue() * rotationSpeed;
            float rotationZ = -Pointer.current.delta.x.ReadValue() * rotationSpeed;
            transform.Rotate(rotationX, 0, rotationZ, Space.World);

        }
    }
}
