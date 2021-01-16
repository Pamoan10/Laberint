using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrSoAmbient : MonoBehaviour
{
    [SerializeField] AudioSource so; //per accedir al so ambient
    bool pausat = false;

    void Start()
    {
        so.ignoreListenerPause = true;
    }

    // Update is called once per frame
    void Update()
    {
        ControlVolum();
    }
    void ControlVolum()
    {
        if (Input.GetKeyDown(KeyCode.B)) MuteFons();
        if (Input.GetKeyDown(KeyCode.M)) MuteAudio();
        if (Input.GetKeyDown(KeyCode.KeypadMinus)) so.volume -= 0.05f;
        if (Input.GetKeyDown(KeyCode.KeypadPlus)) so.volume += 0.05f;
        AudioListener.volume = Mathf.Clamp(AudioListener.volume, 0, 1); //AudioListener por tenir nivells negatius, amb això ho delimito
    }
    void MuteFons()
    {
        pausat = !pausat;
        if (pausat) so.Pause(); else so.Play();
    }
    void MuteAudio()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
