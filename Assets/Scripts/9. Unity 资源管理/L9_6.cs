using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L9_6 : MonoBehaviour
{
    private AudioSource _audioSource;
    public AudioClip _audioClip;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        // _audioSource.clip = _audioClip;
        // _audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            _audioSource.Stop();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            if (_audioSource.isPlaying)
            {
                _audioSource.Pause();
            }
            else
            {
                _audioSource.UnPause();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}
