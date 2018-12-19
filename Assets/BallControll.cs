using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{ 
    //ボールというオブジェクトを紐付ける
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
