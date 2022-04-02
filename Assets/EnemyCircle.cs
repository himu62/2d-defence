using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCircle : MonoBehaviour
{
    private Rigidbody2D rb;
    protected float speed;
    protected float scale;
    protected Color color;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.transform.localScale = new Vector3(scale, scale);

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = color;

        // 出現位置は画面外周のランダムな位置
        float rad = Random.value * 360 * Mathf.PI;
        rb.position = new Vector2(
            Mathf.Cos(rad) * 5,
            Mathf.Sin(rad) * 5
        );
    }

    void Update()
    {
        // プレイヤーに向かって直進する
        float rad = Mathf.Atan2(rb.position.y, rb.position.x);
        rb.velocity = new Vector2(
            Mathf.Cos(rad) * -speed,
            Mathf.Sin(rad) * -speed
        );
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag.Equals("Player")) {
            Destroy(this.gameObject);
        }
    }
}
