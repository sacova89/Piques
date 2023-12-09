using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsFunction : MonoBehaviour
{
    
    public AudioSource  mySound;
    public AudioClip    hoverSound;
    public AudioClip    clickingSound;

    public void HoverSound()
    {
        mySound.PlayOneShot(hoverSound);
    }

    public void ClickingSound()
    {
        mySound.PlayOneShot(clickingSound);
    }



}
