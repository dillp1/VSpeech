using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour
{
    public TMP_Text dialogueText;
    public Button startButton;
    public Button continueButton;

    private string[] dialogueLines = {
        "Hello!",
        "My name is DeeMo.",
        "My job is to demonstrate to you how to correctly convey your ideas through a presentation.",
        "Here are some thing to keep in mind that will take your presentation to the next level.",
        "Number 1 is professionalism.",
        "When presenting, it is paramount that you come across as professional. Make sure to dress appropriately.",
        "Number 2 is volume.",
        "Ensure that you speak loud enough to be heard by all of your audience, but do not yell at them.",
        "Also, speak with clear diction. It's one thing for your audience to hear you, but they must also understand you.",
        "Number 3 is vocabulary.",
        "On the topic of what you are saying, know your audience! Your vocabulary should match who you are speaking to.",
        "Number 4 is attitude.",
        "Even though you may not want to, act like you want to be giving a presentation.",
        "Audiences are more engaged when the presenter doesn't sound and/or look miserable.",
        "Number 5 is speed.",
        "Keep a general pace; not fast to the point you're rambling, but not slow to the point you lose your audience's attention!",
        "Number 6 is purpose.",
        "Make sure that you always keep the main purpose of your presentation in mind.",
        "A presentation without a strong purpose is a presentation that will not have a significant impact on the audience.",
        "Number 7 is body language.",
        "Using your arms and hands while speaking makes you, as the presenter, feel real, but you should keep fidgeting to a minimum.",
        "Number 8 is eye contact.",
        "Make sure you look at your whole audience evenly, not one side more than the other.",
        "Number 9 is content.",
        "Make sure that the information in your speech is organized logically. This will help your audience follow the main content you are trying to convey.",
        "And finally, number 10: PRACTICE!!!",
        "Use this program and other preparation activities to deliver a knockout performance on speech day!",
        "Now you are ready to give an amazing speech. Good luck!"
    };

    private int currentIndex = 0;

    private void Start()
    {
        continueButton.interactable = false; // Disable continue initially
        startButton.onClick.AddListener(StartDialogue);
        continueButton.onClick.AddListener(ContinueDialogue);
    }

    private void StartDialogue()
    {
        currentIndex = 0;
        UpdateDialogue();
        startButton.gameObject.SetActive(false); // Hide the Start button after clicking
        continueButton.interactable = true; // Enable the Continue button
    }

    private void ContinueDialogue()
    {
        currentIndex++;
        UpdateDialogue();
    }

    private void UpdateDialogue()
    {
        if (currentIndex < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentIndex];
        }
        else
        {
            dialogueText.text = "End of dialogue.";
            continueButton.interactable = false; // Disable the Continue button at the end

            // Load a new scene when the dialogue ends
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        // Replace "YourNextSceneName" with the name of the scene you want to load
        SceneManager.LoadScene("1 Start Scene");
    }
}