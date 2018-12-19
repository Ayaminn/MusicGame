using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{ 
    //ボールというオブジェクトを紐付ける
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball, new Vector3(0, 10, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
