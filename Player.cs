using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float MaxSpeed = 3f;
    // public float JumpForce = 5f;
    // public bool Jumping = false;
    // public LayerMask IgnoreMe;

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;

    void Start(){
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }


 private void FixedUpdate(){

    //Player input
        int horizontal = 0;
        // int vertical = 0;

        if(Input.GetKey(KeyCode.A)){
            horizontal -= 1;
            sr.flipX = true;

        }

        if(Input.GetKey(KeyCode.D)){
            horizontal += 1;
            sr.flipX = false;

        }

         

        rb.velocity = new Vector2(horizontal * MoveSpeed, rb.velocity.y);

        if(horizontal != 0){
              anim.SetBool("walk", true);
        }
        else {
            anim.SetBool("walk", false);
        }
      
    // RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, ~IgnoreMe);
    // Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);

    // bool Grounded = false;
    // if(hit.collider){
    //     Grounded = true;
    // }

    //   if(vertical > 0 && Grounded == true && Jumping == false){
    //     rb.AddForce(Vector2.up * JumpForce);
    //     Jumping = true;
    //     StartCoroutine(wait());
    //   }

       

    }

    // IEnumerator wait() {
    //     yield return new WaitForSeconds(0.25f);
    //     Jumping = false;

    // }


    }


