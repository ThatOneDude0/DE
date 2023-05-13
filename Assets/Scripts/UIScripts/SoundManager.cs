using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _musicAudioSource;
    [SerializeField] private AudioSource _soundAudioSource;

    //�������� ������
    public void OnPlayMusic()
    {
        _musicAudioSource.Play();
    }

    //��������� ������
    public void OnStopMusic()
    {
        _musicAudioSource.Stop();
    }

    //������ ����
    public void OnMuteSound()
    {
        _soundAudioSource.mute = true;
    }

    //�������� ����
    public void UnMuteSound()
    {
        _soundAudioSource.mute = false;
    }
}
