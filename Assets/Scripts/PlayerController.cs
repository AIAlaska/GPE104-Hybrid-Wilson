using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // This script is attached to the player GameObject
    // It is responsible for controlling the player character in the game
    public PlayerPawn playerPawn;

    // Declare Variables
    // These variables define the keys used for player controls
    // The teleportKey is used to teleport the player to a random position when pressed
    public KeyCode teleportKey;

    // These keys are used to control the player's movement and actions
    // The moveForward key is used to move the player forward when pressed
    public KeyCode moveForward;
    // The moveBackward key is used to move the player backward when pressed
    public KeyCode moveBackward;
    // The rotateClockwise key is used to rotate the player clockwise when pressed
    public KeyCode rotateClockwise;
    // The rotateCounterClockwise key is used to rotate the player counter-clockwise when pressed
    public KeyCode rotateCounterClockwise;
    // The worldUp key is used to move the player up when pressed
    public KeyCode worldUp;
    // The worldDown key is used to move the player down when pressed
    public KeyCode worldDown;
    // The worldLeft key is used to move the player left when pressed
    public KeyCode worldLeft;
    // The worldLeft key is used to move the player left when pressed
    public KeyCode worldRight;
    // The turboEngage key is used to engage turbo mode when pressed
    public KeyCode turboEngage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // This method is called once per frame to update the player controls
        // Check if the playerPawn is not null to avoid null reference exceptions
        // This ensures that the playerPawn is assigned before trying to access its methods
        // This method is used to check for player input and perform actions based on the input
        if (playerPawn != null)
        {

            // Check if the teleport key is pressed
            if (Input.GetKeyDown(teleportKey))
            {
                playerPawn.TeleportToRandomPosition();
            }

            // Check if the move forward key is pressed
            if (Input.GetKey(moveForward))
            {
                playerPawn.MoveForward();
            }

            // Check if the move backward key is pressed
            if (Input.GetKey(moveBackward))
            {
                playerPawn.MoveBackward();
            }

            // Check if the rotate clockwise key is pressed
            if (Input.GetKey(rotateClockwise))
            {
                playerPawn.RotateClockwise();
            }

            // Check if the rotate counter-clockwise key is pressed
            if (Input.GetKey(rotateCounterClockwise))
            {
                playerPawn.RotateCounterClockwise();
            }
            // Check if the world up key is pressed
            if (Input.GetKeyDown(worldUp))
            {
                playerPawn.MoveWorldUp();
            }
            // Check if the world down key is pressed
            if (Input.GetKeyDown(worldDown))
            {
                playerPawn.MoveWorldDown();
            }
            // Check if the world left key is pressed
            if (Input.GetKeyDown(worldLeft))
            {
                playerPawn.MoveWorldLeft();
            }
            // Check if the world right key is pressed
            if (Input.GetKeyDown(worldRight))
            {
                playerPawn.MoveWorldRight();
            }

            // Check if the turbo engage key is pressed
            if (Input.GetKeyDown(turboEngage))
            {
                playerPawn.ToggleTurboMode();
            }



        }
  
        

    }
}
