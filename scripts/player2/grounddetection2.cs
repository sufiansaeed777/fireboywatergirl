using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounddetection2 : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "ground" || collision.transform.tag == "browntile")
        {
            player2controller.isGrounded = true;
        }
        else
        {
            player2controller.isGrounded = false;
        }
    }
}
