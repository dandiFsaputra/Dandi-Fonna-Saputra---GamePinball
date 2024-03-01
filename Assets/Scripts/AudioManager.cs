using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public AudioSource sfxmAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayBGM() {
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition) {
        GameObject.Instantiate(sfxmAudioSource, spawnPosition, Quaternion.identity);
    }
}
