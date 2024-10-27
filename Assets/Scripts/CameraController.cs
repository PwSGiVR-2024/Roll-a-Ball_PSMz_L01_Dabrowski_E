using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject Player;
    private Vector3 offset;
    private Vector3 CameraRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset =  transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //// Get mouse movement deltas
        //float mouseX = Input.GetAxis("Mouse X");
        //float mouseY = Input.GetAxis("Mouse Y");

        //// Convert these into a 3D movement vector
        //Vector3 movement = new Vector3(mouseX * 100, 0, mouseY* 100);

        //// Normalize for consistent speed
        //movement = movement.normalized;
        //transform.RotateAround(Player.transform.position, movement, Time.deltaTime);


        transform.position = Player.transform.position + offset;
    }

   
}
