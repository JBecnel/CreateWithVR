using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisBallSound : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        this.audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        AudioClip clip = this.audioSource.clip;
        float volume = this.GetComponent<Rigidbody>().velocity.magnitude/2.0f;
        this.audioSource.PlayOneShot(clip, volume);
    }
}
