using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject coin;
    [SerializeField] bool flag;

    private void Start()
    {
        SpawnCoin();
    }


    private void FixedUpdate()
    {
       if (flag)
        {
            SpawnCoin();
        }
    }

    void SpawnCoin()
    {
        //Instantiate(coin, new Vector3(Random.Range(-20f, 20f), 20f, Random.Range(-20f, 20f)), Quaternion.identity);
        Instantiate(coin, new Vector3(
            transform.position.x + Random.Range(-20f, 20f),
            20f, 
            transform.position.z + Random.Range(-20f, 20f)), Quaternion.identity);
        flag = false;
        StartCoroutine(Deley());
    }

    IEnumerator Deley()
    {
        yield return new WaitForSeconds(2);
        flag = true;
    }
}
