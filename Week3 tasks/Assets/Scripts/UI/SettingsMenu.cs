using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer volumeMixer;
    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        volumeMixer.SetFloat("Volume",volume);
        Debug.Log(volume);
    }

    public void SetAudio(float audio)
    {
        audioMixer.SetFloat("Audio", audio);
        Debug.Log(audio);
    }

    public void Quality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
