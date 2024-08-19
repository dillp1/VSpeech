// ButtonController.cs
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Timer timerScript; // Reference to the Timer script

    void Start()
    {
        // Ensure that the Timer script is attached to the same GameObject
        if (timerScript == null)
        {
            Debug.LogError("Timer script reference is not set. Attach the Timer script to the same GameObject.");
            return;
        }

        // Get the Button component
        Button button = GetComponent<Button>();

        // Add a listener to call the ToggleTimer method when the button is clicked
        button.onClick.AddListener(timerScript.ToggleTimer);
    }
}