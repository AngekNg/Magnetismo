using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTrain : MonoBehaviour
{
    GameObject palitoObj;
    Animator palitoAnimator;

    public void PlayAnim()
    {
        palitoAnimator = GetComponent<Animator>();
        palitoAnimator.SetBool("Play", true);
    }

}
