using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //パーティクルを登録する
    public ParticleSystem particle;

    //コインを回転させる
    void Update()
    {
        transform.Rotate(0, 0, 05f);
    }

    //衝突したらパーティクルを再生する
    private void OnTriggerEnter(Collider other)
    {
        //パーティクルを再生する
        particle.Play();

        //パーティクルを再生後に削除する
        Destroy(particle.gameObject, particle.main.duration);

        //衝突したら自身を削除する
        Destroy(gameObject);
    }
}
