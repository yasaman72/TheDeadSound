using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PLayRandomSound : MonoBehaviour {

    public AudioClip[] audioClips;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
            audioSource.Play();
        }
    }
}
