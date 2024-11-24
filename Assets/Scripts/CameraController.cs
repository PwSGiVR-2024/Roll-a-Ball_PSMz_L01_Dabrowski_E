using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{
    public GameObject Player; // Reference to the player
    public Vector3 cameraPositionOffset = new Vector3(0, 5, -10); // Default camera position offset
    public int PlayerView = 1;


    void Start()
    {
        // Set the default camera view
        SetView(1);
    }

    void Update()
    {
        // Handle camera position switching
        if (Input.GetKeyDown(KeyCode.Alpha1)) SetView(1); // Behind the player
        if (Input.GetKeyDown(KeyCode.Alpha2)) SetView(2); // Right of the player
        if (Input.GetKeyDown(KeyCode.Alpha3)) SetView(3); // In front of the player
        if (Input.GetKeyDown(KeyCode.Alpha4)) SetView(4); // Left of the player

        // Continuously follow the player
        FollowPlayer();
    }

    void SetView(int viewIndex)
    {

        if (viewIndex == 1) // Behind the player
        {
            cameraPositionOffset = new Vector3(0, 5, -15); // Update offset for position
            PlayerView = 1;
        }
        else if (viewIndex == 2) // Left of the player
        {
            cameraPositionOffset = new Vector3(-15, 5, 0);
            PlayerView = 2;


        }
        else if (viewIndex == 3) // In front of the player
        {
            cameraPositionOffset = new Vector3(0, 5, 15);
            PlayerView = 3;
            
        }
        else if (viewIndex == 4) // right of the player
        {
            cameraPositionOffset = new Vector3(15, 5, 0);
            PlayerView = 4;


        }
        else // Default view
        {
            cameraPositionOffset = new Vector3(0, 5, -5);
            PlayerView = 1;
            
        }
    }

    void FollowPlayer()
    {
        // Update camera position based on player's position + offset
        transform.position = Player.transform.position + cameraPositionOffset;

        // Update camera rotation using the rotation offset
        transform.LookAt(Player.transform);

        // Reset isViewChanged if the player moves and re-triggers FollowPlayer()
    }
}
