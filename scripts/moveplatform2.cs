using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplatform2 : MonoBehaviour
{
    public GameObject lever;
    public float limit = 10f;
    public float speed = 2f;
    public float position = 0f;


    private void Update()
    {
        if (lever.transform.rotation.z <= -0.3)
        {
            if (position < limit)
            {
                float thf = speed * Time.deltaTime;
                position += thf;
                GetComponent<Transform>().SetPositionAndRotation(new Vector2(transform.position.x +thf, transform.position.y ), transform.rotation);
            }
        }
        else
        {
            if (position > 0)
            {
                float thf = speed * Time.deltaTime;
                position -= thf;
                GetComponent<Transform>().SetPositionAndRotation(new Vector2(transform.position.x - thf, transform.position.y ), transform.rotation);
            }
        }
    }
}
