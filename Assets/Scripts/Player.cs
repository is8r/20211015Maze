using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //外から調整できるスピードの値
    [Range(0, 100f)] public float speed = 10;

    //毎フレーム実行される
    void FixedUpdate()
    {
        //キーボードの入力を取得する
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //加える力を作成する
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        //Rigidbodyに力を加える
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement * speed);
    }
}
