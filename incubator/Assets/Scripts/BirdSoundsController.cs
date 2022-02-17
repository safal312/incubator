using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSoundsController : MonoBehaviour
    
{
    private AudioSource audioSrc;

    private float musicVolume = 0.0f;
    private float descend = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        float num = Random.Range(0.0f, 1.0f);
        print(descend);

        if (num <= 0.001f)
        {
            descend = 0.0001f;
        }
        else if (num <= 0.008f)
        {
            musicVolume += 0.02f;
            
        }

        if (musicVolume > 0)
        {
            musicVolume -= descend;
            if (descend < 0.001f)
            {
                descend += descend/2;
            }
            descend = Mathf.Clamp01(descend);
            musicVolume = Mathf.Clamp01(musicVolume);
        }

        audioSrc.volume = musicVolume;
    }
}
