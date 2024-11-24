using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{

    public int Score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * Time.deltaTime,1,0);
        transform.Rotate(Vector3.up * Time.deltaTime, 1, 0);

    }


    // This method is called when the collider attached to the GameObject
    // enters a collision with another collider.
    private void OnTriggerEnter(Collider collision)
    {
        
        collision.gameObject.GetComponent<MovementController>().Score += 1;
        collision.gameObject.GetComponent<MovementController>().ScoreText.text = "Score: " + collision.gameObject.GetComponent<MovementController>().Score;

        if (collision.gameObject.GetComponent<MovementController>().Score == 8)
        {
            collision.gameObject.GetComponent<MovementController>().Score = 0;
            SceneManager.LoadScene(2);

        }
        else {
            Debug.Log("Zdobyles Punkt, Ale to i tak tyle warte co ty (czyli nic)");

        }

        gameObject.SetActive(false); ///Removes the ball instead of the collectible

        //Destroy(gameObject);
    }



}
