 using UnityEngine;
 using UnityEngine.InputSystem;

 public class PlayerMovement : MonoBehaviour
 {
     public float moveSpeed = 4.5f;
     private Rigidbody2D playerRb;
     private Vector2 moveInput;
     public Animator animator;

     // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Start()
     {
         playerRb = GetComponent<Rigidbody2D>();
     }
 

 // Update is called once per frame
     void FixedUpdate()
     {
         playerRb.linearVelocity = moveInput * moveSpeed;
         animator.SetBool("Moving", playerRb.linearVelocityY != 0);
     }

     private void OnMove(InputValue value)
     {
         moveInput = value.Get<Vector2>();
     }
 }
 
