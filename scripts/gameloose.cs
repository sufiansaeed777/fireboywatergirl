using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameloose : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag=="Player")
        {
            Debug.Log("gameover");
            SceneManager.LoadScene(0);
        }
    }
}
