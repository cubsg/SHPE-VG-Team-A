using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is not a Script/MonoBehaviour, it just serves to ensure that we use the same pref key throughout the project.
// Basically just allows the typechecker to see if we misspell aimassist.
public class UserConfigManager
{
    public static bool aimAssistEnabled
    {
        get { return PlayerPrefs.GetInt("aimassist", 1) == 1; }
        set { PlayerPrefs.SetInt("aimassist", value ? 1 : 0); }
    }
    public static float volume
    {
        get { return PlayerPrefs.GetFloat("volume", 0.5f); }
        set { PlayerPrefs.SetFloat("volume", value); }
    }
    public static float soundEffects
    {
        get { return PlayerPrefs.GetFloat("sfx", 0.5f); }
        set { PlayerPrefs.SetFloat("sfx", value); }
    }
}
