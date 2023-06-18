using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class ForScript : MonoBehaviour
{
    public GameObject[] coins;

    async void Start()
    {
        for (int i = 0; i < coins.Length; i++)
        {
            GameObject coin = coins[i];
            await Task.Delay(10);
            Vector3 pos = coin.transform.position + (Vector3.up * 5f);
            coin.transform.SetPositionAndRotation(pos, Quaternion.identity);
        }
    }
}
