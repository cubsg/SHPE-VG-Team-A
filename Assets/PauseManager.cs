using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;
    public Text pauseButtonText; // Assign in Inspector

    public void TogglePause()
    {
        if (isPaused)
        {
            Time.timeScale = 1f; // Resume game
            pauseButtonText.text = "Pause"; // Change button text
        }
        else
        {
            Time.timeScale = 0f; // Pause game
            pauseButtonText.text = "Resume"; // Change button text
        }

        isPaused = !isPaused; // Toggle pause state
    }
}
