using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomSEScript : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Bomb"))
            {
                //音(sound1)を鳴らす
                audioSource.PlayOneShot(sound1);
            }
        }
    
}