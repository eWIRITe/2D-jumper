using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moove : MonoBehaviour
{
    public enum Platform
    {
        Android,
        PC
    }

    public Platform platform;

    public float Speed;
    public float howLongJump = 4;

    public bool aLive = true;

    private Rigidbody2D rb;

    public bool isGround;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (aLive == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        isGround = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (platform == Platform.PC)
        {
            if (isGround == true && Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector2.up * howLongJump;
            }
        }
        else
        {
            if (isGround == true && Input.touchCount > 0)
            {
                rb.velocity = Vector2.up * howLongJump;
            }
        }
        
        if (isGround == true)
        {
            anim.SetBool("isJump", false);
        }
        else
        {
            anim.SetBool("isJump", true);
        }
    }

    void Jump()
    {
        transform.position = transform.position + new Vector3(0, howLongJump, 0);
    }
}
