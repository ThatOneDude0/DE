using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _musicAudioSource;
    [SerializeField] private AudioSource _soundAudioSource;

    //Включает музыку
    public void OnPlayMusic()
    {
        _musicAudioSource.Play();
    }

    //Выключает музыку
    public void OnStopMusic()
    {
        _musicAudioSource.Stop();
    }

    //Глушит звук
    public void OnMuteSound()
    {
        _soundAudioSource.mute = true;
    }

    //Включает звук
    public void UnMuteSound()
    {
        _soundAudioSource.mute = false;
    }
}
