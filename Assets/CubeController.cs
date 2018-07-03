using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    // Use this for initialization

    //キューブの移動速度
    private float speed = -0.2f;

    //消滅速度
    private float deadLine = -10;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        //画面外に出たら破棄する
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
	}
}
