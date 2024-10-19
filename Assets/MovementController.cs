using UnityEngine;

public class MovementController : MonoBehaviour
{



    public float moveSpeed = 1;   // Speed of the ball movement
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component attached to the ball
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();
    }

    // Function to handle ball movement
    void MoveBall()
    {
        Vector3 movement = Vector3.zero; // Initialize movement vector

        if (Input.GetKey(KeyCode.W))
        {
            movement += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement += Vector3.back;    // Move in the negative Z direction
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left;    // Move in the negative X direction
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right;   // Move in the positive X direction
        }

        // Apply force to the ball using the calculated movement vector
        rb.AddForce(movement * moveSpeed);

      
    }

}
