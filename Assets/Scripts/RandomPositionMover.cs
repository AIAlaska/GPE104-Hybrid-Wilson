using UnityEngine;

// This script moves a GameObject to a random position within a specified range when any key is pressed
// It also allows the application to be quit when a specific key is pressed
public class RandomPositionMover : MonoBehaviour
{
    //Declare Variables
    // These variables define the range of random positions for the GameObject
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    // This variable defines the key that will be used to quit the application
    public KeyCode quitKey;

    // Declare a Transform variable to hold the reference to the GameObject's Transform component
    private Transform tf;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the Transform component attached to this GameObject
        // This allows us to manipulate the position of the GameObject
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
            Debug.Log("Application is quitting");
        }


        // Check if any key is pressed
        if (Input.anyKey)
        {
            // Generate a random position within the specified range
            Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);

            // Set the position of the transform to the random position
            tf.position = randomPosition;
        }
        


    }
}
