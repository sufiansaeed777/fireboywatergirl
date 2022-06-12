using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
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
        if (collision.transform.tag == "browntile"|| collision.transform.tag == "rock")
        {
            Debug.Log("gameover");
            SceneManager.LoadScene(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, 180, 0);
            //spriteRenderer.flipX = true;
            if (playercontroller.isGrounded == true)
            {
                animator.SetTrigger("Walking");
            }

            rigidbody2D.MovePosition(pos);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, 0, 0);
            //spriteRenderer.flipX = false;
            if (playercontroller.isGrounded == true)
            {
                animator.SetTrigger("Walking");
            }
            rigidbody2D.MovePosition(pos);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && playercontroller.isGrounded == true)
        {
            animator.SetTrigger("Jump");
            playercontroller.isGrounded = false;
            rigidbody2D.AddForce(new Vector2(0, jumpforce * Time.deltaTime), ForceMode2D.Impulse);

        }
        else
        {
            animator.SetTrigger("Idle");
        }

    }
}
