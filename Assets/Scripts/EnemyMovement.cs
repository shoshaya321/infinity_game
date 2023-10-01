using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public Ease ease; 
    // Start is called before the first frame update
    void Start()
    {
        MoveRight();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void MoveRight()
    {
        var temp = transform.DOMoveX(3,speed);
        temp.SetEase(ease);
        temp.OnComplete(MoveLeft);
    }
    void MoveLeft()
    {
        var temp1 = transform.DOMoveX(-3, speed);
        temp1.SetEase(ease);
        temp1.OnComplete(MoveRight);
    }
}
