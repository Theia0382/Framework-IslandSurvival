using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    Animator animator;
    PlayerMovement playerMovement;

    void Awake()
    {
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ( playerMovement.MoveLeft )
        {
            animator.SetBool( "MoveLeft", true );
        }
        else
        {
            animator.SetBool( "MoveLeft", false);
        }
        if ( playerMovement.MoveRight )
        {
            animator.SetBool( "MoveRight", true );
        }
        else
        {
            animator.SetBool( "MoveRight", false);
        }
        if ( playerMovement.MoveUp )
        {
            animator.SetBool( "MoveUp", true );
        }
        else
        {
            animator.SetBool( "MoveUp", false);
        }
        if ( playerMovement.MoveDown )
        {
            animator.SetBool( "MoveDown", true );
        }
        else
        {
            animator.SetBool( "MoveDown", false);
        }
    }
}
