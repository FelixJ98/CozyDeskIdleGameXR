using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerStorage : MonoBehaviour
{
    // Text components to display timer values
    [SerializeField] private TextMeshProUGUI playTimeText;
    [SerializeField] private TextMeshProUGUI focusTimeText;

    // Timer values in seconds
    private int playTimeValue = 0;
    private int focusTimeValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdatePlayTimeDisplay();
        UpdateFocusTimeDisplay();
    }

    // Play Time increment functions
    public void AddPlayTime5()
    {
        playTimeValue += 5;
        UpdatePlayTimeDisplay();
        Debug.Log("Play Time increased by 5. New value: " + playTimeValue);
    }

    public void AddPlayTime10()
    {
        playTimeValue += 10;
        UpdatePlayTimeDisplay();
        Debug.Log("Play Time increased by 10. New value: " + playTimeValue);
    }

    public void AddPlayTime20()
    {
        playTimeValue += 20;
        UpdatePlayTimeDisplay();
        Debug.Log("Play Time increased by 20. New value: " + playTimeValue);
    }

    // Focus Time increment functions
    public void AddFocusTime5()
    {
        focusTimeValue += 5;
        UpdateFocusTimeDisplay();
        Debug.Log("Focus Time increased by 5. New value: " + focusTimeValue);
    }

    public void AddFocusTime10()
    {
        focusTimeValue += 10;
        UpdateFocusTimeDisplay();
        Debug.Log("Focus Time increased by 10. New value: " + focusTimeValue);
    }

    public void AddFocusTime20()
    {
        focusTimeValue += 20;
        UpdateFocusTimeDisplay();
        Debug.Log("Focus Time increased by 20. New value: " + focusTimeValue);
    }

    // Reset functions
    public void ResetPlayTime()
    {
        playTimeValue = 0;
        UpdatePlayTimeDisplay();
        Debug.Log("Play Time reset to 0");
    }

    public void ResetFocusTime()
    {
        focusTimeValue = 0;
        UpdateFocusTimeDisplay();
        Debug.Log("Focus Time reset to 0");
    }

    // Update the Play Time text display
    private void UpdatePlayTimeDisplay()
    {
        if (playTimeText != null)
        {
            playTimeText.text = "Play Time: " + FormatTime(playTimeValue);
        }
    }

    // Update the Focus Time text display
    private void UpdateFocusTimeDisplay()
    {
        if (focusTimeText != null)
        {
            focusTimeText.text = "Focus Time: " + FormatTime(focusTimeValue);
        }
    }

    // Format time value to display in minutes:seconds format
    private string FormatTime(int seconds)
    {
        int minutes = seconds / 60;
        int remainingSeconds = seconds % 60;
        return minutes + ":" + remainingSeconds.ToString("00");
    }

    // Save timer values to PlayerPrefs (optional)
    public void SaveTimerValues()
    {
        PlayerPrefs.SetInt("PlayTimeValue", playTimeValue);
        PlayerPrefs.SetInt("FocusTimeValue", focusTimeValue);
        PlayerPrefs.Save();
    }

    // Load timer values from PlayerPrefs (optional)
    public void LoadTimerValues()
    {
        if (PlayerPrefs.HasKey("PlayTimeValue"))
        {
            playTimeValue = PlayerPrefs.GetInt("PlayTimeValue");
        }

        if (PlayerPrefs.HasKey("FocusTimeValue"))
        {
            focusTimeValue = PlayerPrefs.GetInt("FocusTimeValue");
        }

        UpdatePlayTimeDisplay();
        UpdateFocusTimeDisplay();
    }
}