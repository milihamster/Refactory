using Refactory.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Used for testing Refactorys methods
/// </summary>
public class Testing : MonoBehaviour
{
    void Start()
    {
        var audioControlller = AudioController.Instance;

        var audioSource = audioControlller.CreateAudioSource();
        //audioSource.SetPitch(1.1f).SetPriority(2).PlayOneShot();

    }
}
