using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class WalkScript : MonoBehaviour
{
    public GameObject player;
    private Animator animator;
    AudioSource audiosrc;
    private AudioClip clip;
    public float delay;


    // Start is called before the first frame update
    void Start()
    {
        audiosrc = GetComponent<AudioSource>();
        animator = player.GetComponent<Animator>();
   
    }

    // Update is called once per frame
    void Update()
    {

    }

    void KillAudio()
    {
        audiosrc.Stop();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        //IsMoving = true;
        if (!audiosrc.isPlaying)
        {
            if (animator.GetBool("moving") && other.CompareTag("Player") && !other.isTrigger)
            {

            
                audiosrc.PlayDelayed(.5f);
                Invoke("KillAudio", 1f);
            }
            else {

                audiosrc.Stop();
            }
            
        }
        /*else
        {
            //audiosrc.Pause();
        } */

    }





    IEnumerator playSoundAfterOneSeconds()
    {
        
           
        
        
      // yield return new WaitWhile(() => GetComponent<AudioSource>().isPlaying);

        while (true)
        {
            // Place your method calls
            audiosrc.Play();
            //yield return waitForSeconds(.5f);
        }

    }
}

