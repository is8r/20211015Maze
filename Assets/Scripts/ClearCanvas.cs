using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearCanvas : MonoBehaviour
{
    //パネルを登録する
    public GameObject panel;

    //パーティクルを登録する
    public ParticleSystem particle;

    //テキストエリアを登録する
    public Text clearText;

    //ゲームが開始した時にパネルを隠す
    void Start()
    {
        panel.SetActive(false);
    }

    public void OnEnter()
    {
        //パネルを表示する
        panel.SetActive(true);

        //パーティクルを再生する
        particle.Play();

        //PlayerPrefsから値を取得する
        int nowScore = PlayerPrefs.GetInt("score");

        //スコアをテキストに反映させる
        clearText.text = nowScore.ToString();
    }

    public void OnReplay()
    {
        //MainSceneをロードし直す
        SceneManager.LoadScene("MainScene");
    }

    public void OnTitle()
    {
        //Titleをロードする
        SceneManager.LoadScene("Title");
    }
}
