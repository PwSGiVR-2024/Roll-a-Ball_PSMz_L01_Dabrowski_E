using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MovementController : MonoBehaviour
{

    public Text ScoreText;
    public int Score;
    public float moveSpeed = 1;   // Speed of the ball movement
    private Rigidbody rb;
    Vector3 movement = Vector3.zero; // Initialize movement vector
    public float skyboxRotationSpeed = 0.1f;
    public int PlayerView;  // The PlayerView will be set in Start()
    private CameraController cameraController;

    



// Start is called before the first frame update
void Start()
    {
        Score = 0;
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component attached to the ball
        ScoreText.text = "Score: " + Score.ToString();
        

    }

    void Update()
    {

        cameraController = Camera.main.transform.parent.GetComponent<CameraController>();  // Get the CameraController component

        // Get the current PlayerView value from the CameraController
        PlayerView = cameraController.PlayerView;  // Assign PlayerView from CameraController


        MoveBall(PlayerView);
    }

    public void RotateSkyBox()
    {

        float currentRotation = RenderSettings.skybox.GetFloat("_Rotation");
        RenderSettings.skybox.SetFloat("_Rotation", currentRotation + skyboxRotationSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        // Set the velocity directly to achieve constant speed
        //rb.linearVelocity = movement * moveSpeed;
        rb.AddForce(movement * moveSpeed);
    }

    

    void MoveBall(int currentPlayerView)
    {

        movement = Vector3.zero;

        if (currentPlayerView == 1)
        {
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
        else if (currentPlayerView == 2)
        {
            // Check for input keys and set movement direction
            if (Input.GetKey(KeyCode.W))
            {
                movement += Vector3.right;
                // Move in the positive X direction

            }
            if (Input.GetKey(KeyCode.A))
            {
                movement += Vector3.forward;
                // Move in the negative X direction
            }

            if (Input.GetKey(KeyCode.S))
            {
                movement += Vector3.left;
                
                // Move in the negative X direction
                // Move in the negative Z direction
            }
            if (Input.GetKey(KeyCode.D))
            {
                movement += Vector3.back;
               
                
                // Move in the positive X direction
            }

            // Normalize the movement vector to ensure consistent speed
            if (movement != Vector3.zero)
            {
                movement.Normalize(); // Normalize to keep speed constant regardless of direction
            }


        }
        else if (currentPlayerView == 3)
        {
            // Check for input keys and set movement direction
            if (Input.GetKey(KeyCode.W))
            {
                movement += Vector3.back;    // Move in the negative Z direction
            }

            if (Input.GetKey(KeyCode.S))
            {
                movement += Vector3.forward;

            }

            if (Input.GetKey(KeyCode.A))
            {
                movement += Vector3.right;   // Move in the positive X direction
            }

            if (Input.GetKey(KeyCode.D))
            {
                movement += Vector3.left;

            }

            // Normalize the movement vector to ensure consistent speed
            if (movement != Vector3.zero)
            {
                movement.Normalize(); // Normalize to keep speed constant regardless of direction
            }


        }
        else if (currentPlayerView == 4)
        {


            // Check for input keys and set movement direction
            if (Input.GetKey(KeyCode.W))
            {
                movement += Vector3.left;    // Move in the negative X direction
            }

            if (Input.GetKey(KeyCode.S))
            {
                movement += Vector3.right;   // Move in the positive X direction

            }

            if (Input.GetKey(KeyCode.A))
            {
                movement += Vector3.back;
                // Move in the negative X direction
            }

            if (Input.GetKey(KeyCode.D))
            {
                movement += Vector3.forward;

                // Move in the positive X direction
            }

            // Normalize the movement vector to ensure consistent speed
            if (movement != Vector3.zero)
            {
                movement.Normalize(); // Normalize to keep speed constant regardless of direction
            }

        }else {

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


}
