using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlayer : MonoBehaviour
{
    public float spinSpeed = 10f;
    public int spinDir = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spinDir *= -1;
        }

        transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime * spinDir);
        
    }
}
