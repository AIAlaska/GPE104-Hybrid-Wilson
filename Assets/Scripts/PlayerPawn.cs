using UnityEngine;

// This script defines a PlayerPawn class that allows a GameObject to teleport to a random position within specified bounds
// It also provides a Transform reference to manipulate the GameObject's position using its Transform component
public class PlayerPawn : MonoBehaviour
{
    // Declare Variables
    // These variables define the range of random positions for the GameObject to be teleported to
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // Declare a Transform variable to hold the reference to the GameObject's Transform component
    // This allows us to manipulate the position of the GameObject using its Transform component
    private Transform tf;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the Transform component attached to this GameObject
        tf = transform;
    }



    // Update is called once per frame
    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // If the Escape key is pressed, quit the application
            Application.Quit();
        }

        // Check if the T key is pressed
if (Input.GetKeyDown(KeyCode.T))
        {
            // Generate a random position within the specified range
            Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);

            // Set the position of the transform to the random position
            tf.position = randomPosition;
        }
    }
        
 }

