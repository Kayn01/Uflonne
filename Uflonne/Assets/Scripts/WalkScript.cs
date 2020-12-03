using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class WalkScript : MonoBehaviour
{
    public GameObject player;
    private Animator animator;
    AudioSource audiosrc;
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


    void OnTriggerStay2D(Collider2D other)
    {
        if (animator.GetBool("moving") && other.CompareTag("Player") && !other.isTrigger)
        {
           StartCoroutine(playSoundAfterOneSeconds());
           //audiosrc.PlayDelayed(delay);

        }
        else
        {
            audiosrc.Pause();
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        audiosrc.Stop();
    }


     IEnumerator playSoundAfterOneSeconds()
     {


        yield return new WaitWhile(() => GetComponent<AudioSource>().isPlaying);
        audiosrc.PlayDelayed(.5f);
        //yield return new WaitForSeconds(.001f);
        //
    }  
}
