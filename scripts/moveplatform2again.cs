using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplatform2again : MonoBehaviour
{
    public GameObject lever2;
    public float limit2 = 10f;
    public float speed2 = 2f;
    public float position2 = 0f;


    private void Update()
    {
        if (lever2.transform.rotation.z <= -0.3)
        {
            if (position2 < limit2)
            {
                float thf = speed2 * Time.deltaTime;
                position2 += thf;
                GetComponent<Transform>().SetPositionAndRotation(new Vector2(transform.position.x + thf, transform.position.y), transform.rotation);
            }
        }
        else
        {
            if (position2 > 0)
            {
                float thf = speed2 * Time.deltaTime;
                position2 -= thf;
                GetComponent<Transform>().SetPositionAndRotation(new Vector2(transform.position.x - thf, transform.position.y), transform.rotation);
            }
        }
    }
}
