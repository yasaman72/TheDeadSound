using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerASound : MonoBehaviour {

    public GameObject UIText;
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public Animator animator;
    public string animatorTrigger;

    bool canTrigger;

    private void Start()
    {
        UIText.SetActive(false);
        canTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UIText.SetActive(true);
            canTrigger = true;
            Debug.Log("Entered Trigger!");
        }
    }

    private void Update()
    {
        if(canTrigger)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if (audioSource.isPlaying == false)
                {
                    if(animator != null)
                    {
                        animator.SetTrigger(animatorTrigger);
                    }
                    else
                    {
                        PLaySound();
                    }
                }
            }
        }
    }

    public void PLaySound()
    {
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Exit trigger!");
            UIText.SetActive(false);
            canTrigger = false;
            audioSource.Stop();
        }
    }

    

}
