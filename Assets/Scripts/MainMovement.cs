using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;

    public float brakeSpeed;

    public bool breaked;

    public Rigidbody2D w1rb;
    public Rigidbody2D w2rb;

    public AudioSource audioSource;
    public AudioClip ridingSound;

    private bool doOnce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim1.SetBool("isMoving", false);
        anim2.SetBool("isMoving", false);
        anim3.SetBool("isMoving", false);
        anim4.SetBool("isMoving", false);
        anim5.SetBool("isMoving", false);
        audioSource = GetComponent<AudioSource>();
        //wheels = GetComponentsInScene<WheelJoint2D>();
        doOnce = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (!breaked)
        {
            MainMove();
        }
        

        breaked = false;

      

        if (Input.GetKey("space"))
        {
            breaked = true;
            
           
        }

        if (breaked)
        {
            rb.velocity = new Vector2(rb.velocity.x - brakeSpeed, rb.velocity.y);
            w1rb.velocity = new Vector2(rb.velocity.x - brakeSpeed, rb.velocity.y);
            w2rb.velocity = new Vector2(rb.velocity.x - brakeSpeed, rb.velocity.y);
            anim1.SetBool("isMoving", false);
            anim2.SetBool("isMoving", false);
            anim3.SetBool("isMoving", false);
            anim4.SetBool("isMoving", false);
            anim5.SetBool("isMoving", false);
            doOnce = false;
            audioSource.Stop();
        }

        if (rb.velocity.x < 0)
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
            w1rb.velocity = new Vector2(0f, rb.velocity.y);
            w2rb.velocity = new Vector2(0f, rb.velocity.y);
        }

        
    }

    public void PlayAudio()
    {
        audioSource.clip = ridingSound;
        audioSource.Play();
    }


    void MainMove()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");


        

        if (moveInput > 0)
        {
            anim1.SetBool("isMoving", true);
            anim2.SetBool("isMoving", true);
            anim3.SetBool("isMoving", true);
            anim4.SetBool("isMoving", true);
            anim5.SetBool("isMoving", true);
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
            if (!doOnce)
            {
                PlayAudio();
                doOnce = true;
            }
            
        }

        if (moveInput == 0)
        {
            anim1.SetBool("isMoving", false);
            anim2.SetBool("isMoving", false);
            anim3.SetBool("isMoving", false);
            anim4.SetBool("isMoving", false);
            anim5.SetBool("isMoving", false);
            doOnce = false;
            audioSource.Stop();
        }

        if (moveInput < 0)
        {
            moveInput = 0;
        }

       
    }


}
