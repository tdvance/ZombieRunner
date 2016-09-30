using UnityEngine;
using System.Collections;

public class HelicopterCall : MonoBehaviour {
    private AudioSource[] audioSources;

    private bool called = false;

    public AudioClip rogerMessage;
    public AudioClip helicopterClip;

    // Use this for initialization
    void Start() {
        audioSources = GetComponents<AudioSource>();

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetButtonDown("Helicopter") && !called) {
            CallHelicopter();
        }


    }

    void CallHelicopter() {
        called = true;
        audioSources[0].clip = helicopterClip;
        audioSources[0].loop = true;
        audioSources[0].spatialBlend = 0;
        audioSources[0].Play();
        audioSources[1].clip = rogerMessage;
        audioSources[1].loop = false;
        audioSources[1].spatialBlend = 0;
        audioSources[1].Play();
        Invoke("Launch", 2.716f);
        
    }

    void Launch() {
        audioSources[0].Stop();
        audioSources[0].spatialBlend = 1;
        audioSources[0].Play();
    }

}
