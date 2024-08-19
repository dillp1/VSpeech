using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Specify the name of the scene you want to load
    public string sceneToLoad = "YourSceneName";

    // This function is called when the attached UI button is clicked
    public void OnButtonClick()
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}