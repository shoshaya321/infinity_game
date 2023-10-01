using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerZigZag : MonoBehaviour
{
    Vector3 newPos;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        newPos = new Vector3(-2, transform.localPosition.y, transform.localPosition.z);
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.localPosition = Vector3.MoveTowards(transform.localPosition, newPos, speed * Time.deltaTime);
        if (Input.GetMouseButtonDown(0) && transform.localPosition.x == 2)
        {
            newPos = new Vector3(-2, transform.localPosition.y, transform.localPosition.z);
           

        }

        else if (Input.GetMouseButtonDown(0) && transform.localPosition.x == -2)
        {
            newPos = new Vector3(2, transform.localPosition.y, transform.localPosition.z);
          


        }
    }
}
