using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //現在のスコアをメモ
    public int score = 0;

    //メッセージを受け取る
    public void OnScore(int num)
    {
        //print($"{num} 点が実行されたよ！");
        score += num;

        //Textコンポーネントを取得する
        Text scoreText = GetComponent<Text>();

        //scoreをテキストエリアに表示させる
        scoreText.text = score.ToString();
    }
}
