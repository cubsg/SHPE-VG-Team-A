using UnityEngine;
using TMPro;

class AimAssistConfig : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    void Start()
    {
        UpdateButtonLabel();
    }

    public void ToggleAimAssist()
    {
        UserConfigManager.aimAssistEnabled = !UserConfigManager.aimAssistEnabled;

        UpdateButtonLabel();
    }

    private void UpdateButtonLabel()
    {
        text.text = "Aim Assist: " + (UserConfigManager.aimAssistEnabled ? "On" : "Off");
    }
}
