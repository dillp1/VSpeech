using UnityEngine;
using UnityEngine.XR;

public class VRResetOrientation : MonoBehaviour
{
    void Start()
    {
        // Check if the XR device is present and supports recentering
        if (XRSettings.isDeviceActive && XRDevice.GetTrackingSpaceType() == TrackingSpaceType.RoomScale)
        {
            // Reset the player's orientation to face forward
            InputTracking.Recenter();
            
            // Optionally, you can add additional logic here, such as notifying the user or logging the event
            Debug.Log("Player orientation reset to forward.");
        }
        else
        {
            // Log a warning if VR is not active or does not support recentering
            Debug.LogWarning("Unable to reset orientation. VR device not present or does not support recentering.");
        }
    }

    void ResetPlayerOrientation()
    {
        // Check if the XR device is present and supports recentering
        if (XRSettings.isDeviceActive && XRDevice.GetTrackingSpaceType() == TrackingSpaceType.RoomScale)
        {
            // Reset the player's orientation to face forward
            InputTracking.Recenter();
            
            // Optionally, you can add additional logic here, such as notifying the user or logging the event
            Debug.Log("Player orientation reset to forward.");
        }
        else
        {
            // Log a warning if VR is not active or does not support recentering
            Debug.LogWarning("Unable to reset orientation. VR device not present or does not support recentering.");
        }
    }
}
