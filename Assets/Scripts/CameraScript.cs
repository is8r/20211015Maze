using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //追いかけるターゲット
    public GameObject player;

    //自分とターゲットの差分
    public Vector3 offset;

    //ゲーム開始時に一回実行される
    void Start()
    {
        //自分とターゲットの差分を保持する
        offset = transform.position - player.transform.position;
    }

    //毎フレーム実行する
    void Update()
    {
        //ターゲットの座標に差分を追加した座標まで移動する
        transform.position = player.transform.position + offset;
    }
}
