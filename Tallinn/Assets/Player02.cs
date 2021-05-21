using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player02 : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private SpriteRenderer mySR;

    

    private Animator anim;
    
    void Start()
    {
        
        mySR = GetComponent<SpriteRenderer>();
        anim = gameObject.GetComponent<Animator>();
        moveSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        Move();
        PlayerAnimW();
        PlayerAnimS();
        PlayerAnimA();
        PlayerAnimD();
    }
    

    public void Move()
    {


        if (Input.GetKey(KeyCode.W))
        {

            
            transform.Translate
            (new Vector2(0, moveSpeed) * Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.S))
        {

            
            transform.Translate
            (new Vector2(0, -moveSpeed) * Time.deltaTime);
            

        }


        if (Input.GetKey(KeyCode.A))
        {
            

            transform.Translate
            (new Vector2(-moveSpeed, 0) * Time.deltaTime);

            
            if (mySR != null)
            {
                mySR.flipX = true;
            }
        }
        

        if (Input.GetKey(KeyCode.D))
        {
            

            transform.Translate
            (new Vector2(moveSpeed, 0) * Time.deltaTime);

            
            if (mySR != null)
            {
                mySR.flipX = false;
            }
        }
        

        if (Input.GetKey(KeyCode.LeftShift) == true)
        {

            moveSpeed = 8.0f;

            anim.SetBool("shiftbool", true);
        }
        else if (Input.GetKey(KeyCode.LeftShift) == false)
        {
            
            moveSpeed = 5.0f;

            anim.SetBool("shiftbool", false);
             
        }
        
    }
    public void PlayerAnimW()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            anim.SetBool("boolW", true);
        }
        else if (Input.GetKey(KeyCode.W) == false)
        {
            anim.SetBool("boolW", false);
        }
    }
    public void PlayerAnimS()
    {
        if (Input.GetKey(KeyCode.S) == true)
        {
            anim.SetBool("boolS", true);
        }
        else if (Input.GetKey(KeyCode.S) == false)
        {
            anim.SetBool("boolS", false);
        }
    }
    public void PlayerAnimA()
    {
        if (Input.GetKey(KeyCode.A) == true)
        {
            anim.SetBool("boolA", true);
        }
        else if (Input.GetKey(KeyCode.A) == false)
        {
            anim.SetBool("boolA", false);
        }
    }
    public void PlayerAnimD()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            anim.SetBool("boolD", true);
        }
        else if (Input.GetKey(KeyCode.D) == false)
        {
            anim.SetBool("boolD", false);
        }
    }

}
