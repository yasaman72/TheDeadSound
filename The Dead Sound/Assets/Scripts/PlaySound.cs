﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    public AudioSource audioSource;

    public void PLayMySound()
    {
        GetComponent<TriggerASound>().PLaySound();
    }
}
