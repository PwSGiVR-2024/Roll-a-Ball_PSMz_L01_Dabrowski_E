using UnityEngine;

public class MovementController : MonoBehaviour
{


    public int Score;
    public float moveSpeed = 1;   // Speed of the ball movement
    private Rigidbody rb;
    Vector3 movement = Vector3.zero; // Initialize movement vector

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component attached to the ball
    }

    void Update()
    {
        MoveBall();
    }

    void FixedUpdate()
    {
        // Set the velocity directly to achieve constant speed
        //rb.linearVelocity = movement * moveSpeed;
        rb.AddForce(movement * moveSpeed);
    }



    void MoveBall()
    {

        movement = Vector3.zero;

        // Check for input keys and set movement direction
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

        // Normalize the movement vector to ensure consistent speed
        if (movement != Vector3.zero)
        {
            movement.Normalize(); // Normalize to keep speed constant regardless of direction
        }

        

        
    }


}
