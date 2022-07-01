using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDoor : MonoBehaviour
{
    public Animator anim;

    public void OpenDoor()
    {
        anim.SetTrigger("OpenDoor");
    }
}
