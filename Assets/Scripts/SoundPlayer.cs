using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip _jump;
    [SerializeField] private AudioClip _platformCrashes;
    [SerializeField] private AudioClip _dead;
    private AudioSource _audioSource;
    public static SoundPlayer Instance;
    private SoundPlayer(){}
    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }
    private void Start()
    {
        _audioSource= GetComponent<AudioSource>();
    }
    public void PlayJumpSound()
    {
        _audioSource.PlayOneShot(_jump);
    }
    public void PlayPlatformCrashesSound()
    {
        _audioSource.PlayOneShot(_platformCrashes);
    }
    public void PlayDeadSound()
    {
        _audioSource.PlayOneShot(_dead);
    }
}
