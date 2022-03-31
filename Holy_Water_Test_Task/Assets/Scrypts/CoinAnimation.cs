using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimation : MonoBehaviour
{
    Rigidbody coinBody;

    private void Start()
    {
        coinBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (transform.position.y <= 1.5)
        {
            coinBody.useGravity = false;
            coinBody.drag = 20;
            transform.rotation *= Quaternion.AngleAxis(1, Vector3.up);
            StartCoroutine(CoinDestroy());
        }
    }

    

    IEnumerator CoinDestroy()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }
}
