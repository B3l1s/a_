using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;

    public void OnOpenDoor()
    {
        anim.SetTrigger("Opendoor");
    }

}
