using UnityEngine;

public class PlayerPawn : MonoBehaviour
{
    // Declare Variables
    // These variables define the range of random positions for the GameObject to be teleported to
    public float minX;

    public float maxX;

    public float minY;

    public float maxY;

    private bool isTurboActive = false; // Flag to track turbo state
    // Declare a rotationSpeed variable to control the speed of the GameObject's rotation
    public float rotationSpeed; // Speed of rotation in degrees per second
    public float turboMultiplier; // Multiplier for speed and rotation when turbo is active
    public float worldTeleportSpeed;// Speed of world teleport in units per second
    // Declare a normalSpeed variable to control the speed of the GameObject's movement
    public float normalSpeed;

    // Declare a Transform variable to hold the reference to the GameObject's Transform component
    // This allows us to manipulate the position of the GameObject using its Transform component
    private Transform tf;

    // This method is called once per frame to update the GameObject's state
    // It is used to update the GameObject's state or perform actions that need to be checked every frame
    void Update()
    { }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the Transform component of the GameObject this script is attached to
        tf = transform;
    }
    // This method teleports the GameObject to a random position within the specified bounds

    
    public void TeleportToRandomPosition()
    {
        // Generate a random position within the specified bounds
        // The random position is generated using the Random.Range method for both X and Y coordinates
        Vector3 randomPosition = new Vector3(
               Random.Range(minX, maxX), // Generate a random X position within the specified bounds
               Random.Range(minY, maxY), // Generate a random Y position within the specified bounds
               tf.position.z // Keep the current Z position of the GameObject
        );
        tf.position = randomPosition;
    }
    // This method is called to move the GameObject forward in the direction
    public void MoveForward()
    {
        float currentSpeed = normalSpeed;
        if (isTurboActive)
        {
            // If turbo mode is active, multiply the normal speed by the turbo multiplier
            // This allows the GameObject to move faster when turbo mode is engaged
            currentSpeed *= turboMultiplier;
        }
        // Calculate the position offset based on the current speed and direction
        // The position offset is calculated by multiplying the up direction of the Transform by the current speed and delta time
        Vector3 positionOffset = tf.up * currentSpeed * Time.deltaTime;
        tf.position = tf.position + positionOffset;
    }

    public void MoveBackward()
    {
        // This method is called to move the GameObject backward
        float currentSpeed = normalSpeed;
        if (isTurboActive)
        {
            currentSpeed *= turboMultiplier;
        }
        Vector3 positionOffset = -tf.up * currentSpeed * Time.deltaTime;
        tf.position = tf.position + positionOffset;
    }
    public void RotateClockwise()
    {
        // This method is called to rotate the GameObject clockwise
        float currentRotationSpeed = rotationSpeed;
        if (isTurboActive)
        {
            currentRotationSpeed *= turboMultiplier;
        }
        tf.Rotate(0, 0, currentRotationSpeed * Time.deltaTime);
    }
    public void RotateCounterClockwise()
    {
        // This method is called to rotate the GameObject counter-clockwise
        float currentRotationSpeed = rotationSpeed;
        if (isTurboActive)
        {
            currentRotationSpeed *= turboMultiplier;
        }
        tf.Rotate(0, 0, -currentRotationSpeed * Time.deltaTime);
    }
    public void MoveWorldUp()
    {
        // This method is called to move the GameObject up (North) in the world space 
        // The worldUp key is used to move the player up when pressed
        // The position offset is calculated by multiplying the up direction of the Transform by the world teleport speed
        Vector3 positionOffset = Vector3.up * worldTeleportSpeed;
        tf.position = tf.position + positionOffset;
    }
    public void MoveWorldDown()
    {
        // This method is called to move the GameObject down (South) in the world space
        Vector3 positionOffset = Vector3.down * worldTeleportSpeed;
        tf.position = tf.position + positionOffset;
    }
    public void MoveWorldLeft()
    {
        // This method is called to move the GameObject left (West) in the world space
        Vector3 positionOffset = Vector3.left * worldTeleportSpeed;
        tf.position = tf.position + positionOffset;
    }
    public void MoveWorldRight()
    {
        // This method is called to move the GameObject right (East) in the world space
        Vector3 positionOffset = Vector3.right * worldTeleportSpeed;
        tf.position = tf.position + positionOffset;
    }

    // Method to toggle turbo mode
    public void ToggleTurboMode()
    {
        isTurboActive = !isTurboActive; // Flip the turbo state
    }
    //death code logic 
    public void Die()
    {
        // Logic for handling death, such as playing an animation or destroying the GameObject
        Debug.Log("Player has died.");
        Destroy(gameObject); // Destroy the GameObject when it dies
    }
}
