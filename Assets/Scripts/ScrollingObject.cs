using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{

    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb2d.velocity = new Vector2(GameManager.instance.groundSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameOver) rb2d.velocity = Vector2.zero;
    }
}
