using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounddetection : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.transform.tag== "ground" || collision.transform.tag == "bluetile")
        {
            playercontroller.isGrounded = true;
        }
        else
        {
            playercontroller.isGrounded = false;
        }
    }
}
