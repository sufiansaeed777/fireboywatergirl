using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfollower : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public int track = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) ){
            track = 1;
        }
        else if(Input.GetKey(KeyCode.RightArrow) ||Input.GetKey(KeyCode.LeftArrow) ||Input.GetKey(KeyCode.UpArrow)){
            track = 2;
        }
        if (track == 1)
        {
            GetComponent<Transform>().SetPositionAndRotation(new Vector3(player1.transform.position.x, player1.transform.position.y, -10), transform.rotation);
        } 
        else 
        {
            GetComponent<Transform>().SetPositionAndRotation(new Vector3(player2.transform.position.x, player2.transform.position.y, -10), transform.rotation);
        }
    }
}