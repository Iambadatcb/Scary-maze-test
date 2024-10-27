using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject image;
    public AudioClip clip; 

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        image.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))  
        {
            audioSource.PlayOneShot(clip);
            image.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
