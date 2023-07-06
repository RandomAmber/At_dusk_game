using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_jumping : MonoBehaviour
{

private Rigidbody2D rb;
public float jumpAmount = 12;
public GameObject tree;
public bool onFloor = true;

    void Start(){
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.W) && onFloor == true){
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            onFloor = false;
        }
        

    }

void OnCollisionEnter2D(Collision2D other) {
    Debug.Log("blah");
        if(other.gameObject == tree){
        onFloor = true;
    }
    }


    //that would be cool but it doesn't work:
    // [SerializeField] float jumpHeight = 5;
    // [SerializeField] float gravityScale = 5;

    // float velocity;
    // [SerializeField] float floorHeight = 0.5f;
    // [SerializeField] Transform feet;
    // [SerializeField] ContactFilter2D filter;
    // public bool isGrounded;
    // Collider2D[] results = new Collider2D[1];

    // private void Update() {
    //     velocity += Physics2D.gravity.y * gravityScale * Time.deltaTime;
    //     if (Physics2D.OverlapBox(feet.position, feet.localScale, 0, filter, results) > 0 && velocity < 0){
    //         velocity = 0;
    //         Vector2 surface = Physics2D.ClosestPoint(transform.position, results[0]) + Vector2.up * floorHeight;
    //         transform.position = new Vector3(transform.position.x, surface.y, transform.position.z);
    //         isGrounded = true;
    //     }
    //     else {
    //         isGrounded = false;
    //     }
    //     if (Input.GetKeyDown(KeyCode.Space) && isGrounded){
    //         velocity = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * gravityScale));
    //     }
    //     transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
        
    // }
    
}
