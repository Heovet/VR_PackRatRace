using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip creepyMusic;
    bool fade = false;
    
    // Update is called once per frame
    void Update() {
        if (fade) {
            audioSource.volume -= 0.01f;
            print(audioSource.volume);
            if (audioSource.volume <= 0) {
                fade = false;
            }
        }
    }


    public void CreepyTime(int lvl)
    {
        if (lvl == 1) {
            fade = true;
        }
        else if (lvl == 2) {
            fade = true;
            print(fade);
            StartCoroutine(Lv2NewMusic());
              
        }
        
    }

    IEnumerator Lv2NewMusic() {
        yield return new WaitForSeconds(6);

        print("CREEPY_AUDIO");

        audioSource.clip = creepyMusic;
        audioSource.volume = 1;
        audioSource.Play();
        audioSource.loop = true;
    }


}
