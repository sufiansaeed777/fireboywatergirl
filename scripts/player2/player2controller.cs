using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player2controller : MonoBehaviour
{
    public Vector2 pos;
    public Rigidbody2D rigidbody2D;
    public float speed = 5f;
    public float jumpforce = 5f;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public static bool isGrounded=true;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "bluetile"|| collision.transform.tag == "rock")
        {
            Debug.Log("gameover");
            SceneManager.LoadScene(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, 180, 0);
           //spriteRenderer.flipX = true;
            if (player2controller.isGrounded == true)
            {
                animator.SetTrigger("Walking2");
            }
            //rigidbody2D.AddForce(new Vector2(-jumpforce * Time.deltaTime,0), ForceMode2D.Impulse);
            rigidbody2D.MovePosition(pos);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, 0, 0);
            //spriteRenderer.flipX = false;
            if (player2controller.isGrounded == true)
            {
                animator.SetTrigger("Walking2");
            }
            //rigidbody2D.AddForce(new Vector2(jumpforce * Time.deltaTime,0), ForceMode2D.Impulse);
            rigidbody2D.MovePosition(pos);
        }
        else if (Input.GetKeyDown(KeyCode.W) && player2controller.isGrounded == true)
        {
            animator.SetTrigger("Jump2");
            player2controller.isGrounded = false;
            rigidbody2D.AddForce(new Vector2(0, jumpforce * Time.deltaTime), ForceMode2D.Impulse);

        }
        else
        {
            animator.SetTrigger("Idle2");
        }

    }
}

