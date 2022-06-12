using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformgenerator : MonoBehaviour
{
    public GameObject[] Platforms;
    public Transform startposition;
    public float gap;
    // Start is called before the first frame update
    public int count = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count<=10)
        {
            count++;
            int i = Random.Range(0, Platforms.Length);
            Vector3 pos = startposition.position;
            Instantiate(Platforms[i], pos, Platforms[i].transform.rotation);
            pos.x += gap;
            startposition.position = pos;
        }
    }
        
}
