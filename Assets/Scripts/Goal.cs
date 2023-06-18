using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //パーティクルを登録する
    public ParticleSystem particle;

    //クリアパネルを登録する
    public GameObject clearCanvas;

    //衝突したらパーティクルを再生する
    private void OnTriggerEnter(Collider other)
    {
        //クリアパネルを開く
        clearCanvas.SendMessage("OnEnter");

        //パーティクルを再生する
        particle.Play();

        //パーティクルを再生後に削除する
        Destroy(particle.gameObject, particle.main.duration);

        //衝突したら自身を削除する
        Destroy(gameObject);
    }
}
