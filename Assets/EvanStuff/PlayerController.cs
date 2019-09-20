using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Animator anim;
    Rigidbody2D bod;

    

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        bod = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        anim.SetBool("isWalking", false);

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        bod.velocity = new Vector2(h * 4, v * 4);


        if(bod.velocity.y < -0.1f || bod.velocity.y > 0.1f)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("LastMoveY", v);
            anim.SetFloat("LastMoveX", 0);
        }
        else if (bod.velocity.x < -0.1f || bod.velocity.x > 0.1f)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("LastMoveX", h);
            anim.SetFloat("LastMoveY", 0);
        }

        anim.SetFloat("MoveX", bod.velocity.x);
        anim.SetFloat("MoveY", bod.velocity.y);

        /*if (bod.velocity.y < -0.1f)
        {

            anim.SetBool("isWalking", true);
            anim.SetBool("facingDown", true);
            anim.SetBool("facingUp", false);
            anim.SetBool("facingRight", false);
        }
        else if (bod.velocity.y > 0.1f)
        {

            anim.SetBool("isWalking", true);
            anim.SetBool("facingDown", false);
            anim.SetBool("facingUp", true);
            anim.SetBool("facingRight", false);
        }
        else if(bod.velocity.x > 0.1f)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("facingDown", false);
            anim.SetBool("facingUp", false);
            anim.SetBool("facingRight", true);
        }
        else if (bod.velocity.x < -0.1f)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("facingDown", false);
            anim.SetBool("facingUp", false);
            anim.SetBool("facingRight", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
            //anim.SetBool("facingDown", false);
        }*/
    }
}
