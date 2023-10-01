using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitPlayer : MonoBehaviour
{
    public GameObject sphereRight;
    public GameObject sphereLeft;
    public float speed;
    float minX;
    float maxX = 3f;
    // Start is called before the first frame update
    void Start()
    {
        minX = sphereRight.transform.localPosition.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Split();
        }
        else
        {
            Back();
        }
        
    }

    void Split()
    {
        if (sphereRight.transform.localPosition.x <= maxX)
        {
            sphereRight.transform.localPosition += Vector3.right * speed * Time.deltaTime;
            sphereLeft.transform.localPosition += Vector3.left * speed * Time.deltaTime;

        }
   
    }

    void Back()
    {
        if(sphereRight.transform.localPosition.x >= minX)
        {
            sphereRight.transform.localPosition += Vector3.left * speed * Time.deltaTime;
            sphereLeft.transform.localPosition += Vector3.right * speed * Time.deltaTime;

        }
        
    }
}
