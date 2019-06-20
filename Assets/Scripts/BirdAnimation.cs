using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimation : MonoBehaviour
{

    private Animator animator;
    private Bird bird;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        bird = GetComponent<Bird>();
    }

    // Update is called once per frame
    void Update()
    {

        if (bird.IsDead) animator.SetTrigger("Dead");
        else if (bird.IsFlapping) animator.SetTrigger("Flap");
    }
}
