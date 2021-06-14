using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllenMovement : MonoBehaviour
{
    public Animator anim;
    [SerializeField] private float idleState = 0;
    [SerializeField] private bool isWalking = false;
    [SerializeField] private float speedX = 0;
    [SerializeField] private float speedY = 0;
    [SerializeField] 


    public bool IsWalking { get => isWalking; set => isWalking = value; }

    private void Update()
    {
        speedX = Input.GetAxis("Horizontal");
        speedY = Input.GetAxis("Vertical");

        if (speedX != 0 || speedY != 0)
        {
            isWalking = true;
            anim.SetBool("Walking", true);
            anim.SetFloat("SpeedX", speedX);
            anim.SetFloat("SpeedY", speedY);

        }
        else
        {
            isWalking = false;
            anim.SetBool("Walking", false);
            anim.SetFloat("SpeedX", 0);
            anim.SetFloat("SpeedY", 0);

        }
    }
}
