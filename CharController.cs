using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private CharacterController _charController;
    private Animator _animator;

    private float inputX;
    private Vector3 v_movement;
    public float moveSpeed;
    public float jumpSpeed;
    private float ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tempPlayer = GameObject.FindGameObjectWithTag("Player");
        _charController = tempPlayer.GetComponent<CharacterController>();
        _animator = tempPlayer.GetComponent<Animator>();
    }
     
    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0f, 270f, 0f);
        }

        if (inputX == 0)
        {
            _animator.SetBool("isRun", false);
        }
        else
        {
            _animator.SetBool("isRun", true);
        }

        ySpeed += Physics.gravity.y * Time.deltaTime;

        if (_charController.isGrounded)
        {
            //ySpeed = 0f;
            if (Input.GetButtonDown("Jump"))
            {
                ySpeed = jumpSpeed;
                _animator.SetBool("isJump", true);
            }
            else
            {
                _animator.SetBool("isJump", false);
                
            }
        }

        Vector3 velocity = v_movement * moveSpeed;
        velocity.y = ySpeed;

        v_movement = new Vector3(inputX * moveSpeed, 0, 0);
        _charController.Move(velocity);

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Box")
        {
            _animator.SetInteger("isPush2", 2);
        }
       
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Box")
        {
             _animator.SetInteger("isPush2", 1);
        }
    }

    /*private void FixedUpdate()
    {
        v_movement = new Vector3(inputX * moveSpeed, 0, 0);
        _charController.Move(v_movement);
    }*/
}
