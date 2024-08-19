using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class MovementManager : MonoBehaviour
{
    public GameObject coloredObject;
    public Color standingStillColor = Color.green;
    public Color movingColor = Color.red;

    public TextMeshProUGUI scoreText;
    public int startingScore = 100; // Change this to 100
    public int scoreDecreaseAmount = 5;
    public float decreaseInterval = 0.5f; // Decrease score every half second of movement

    private int currentScore;
    private float movementTimer;
    private bool isScoreActive = false; // Added flag to track whether the score is active

    void Start()
    {
        currentScore = startingScore;
        movementTimer = 0.0f;
        UpdateScoreText();
    }

    void Update()
    {
        // Check if the score is active before updating
        if (!isScoreActive)
            return;

        // Get the user's velocity
        Vector3 velocity = GetUserVelocity();

        // Check if the user is moving
        bool isMoving = velocity.magnitude > 0.1f;

        // Change the color of the object based on movement
        coloredObject.GetComponent<Renderer>().material.color = isMoving ? movingColor : standingStillColor;

        // Update the movement timer
        if (isMoving)
        {
            movementTimer += Time.deltaTime;
        }
        else
        {
            movementTimer = 0.0f;
        }

        // Decrease the score based on the timer
        if (movementTimer >= decreaseInterval)
        {
            DecreaseScore();
            movementTimer = 0.0f; // Reset the timer
        }
    }

    Vector3 GetUserVelocity()
    {
        // Assuming XRNode.CenterEye, but you can adjust this based on your setup
        InputDevice device = InputDevices.GetDeviceAtXRNode(XRNode.CenterEye);

        // Try to get the velocity feature
        if (device.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity))
        {
            return velocity;
        }

        // If failed, return a default value
        return Vector3.zero;
    }

    void DecreaseScore()
    {
        currentScore -= scoreDecreaseAmount;

        // Ensure the score doesn't go below 0
        currentScore = Mathf.Max(0, currentScore);

        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "" + currentScore.ToString();
        }
    }

    // Method to start the score script (called from a button press, for example)
    public void StartScore()
    {
        isScoreActive = true;
    }

    // Method to stop/pause the score script (called from a button press, for example)
    public void StopScore()
    {
        isScoreActive = false;
    }
}
