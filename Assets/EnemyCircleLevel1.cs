using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCircleLevel1 : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        // 出現位置は画面外周のランダムな位置
        float rad = Random.value * 360 * Mathf.PI;
        rb.position = new Vector2(
            Mathf.Cos(rad) * 5,
            Mathf.Sin(rad) * 5
        );

        // プレイヤーに向かって直進する
        rb.velocity = new Vector2(
            Mathf.Cos(rad) * -1,
            Mathf.Sin(rad) * -1
        );
    }

    void OnCollisionEnter2D()
    {
        Destroy(this);
    }
}
