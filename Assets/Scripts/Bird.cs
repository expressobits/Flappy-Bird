using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] [AddComponentMenu("Flappy/Bird")]
public class Bird : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private bool isDead;

    [Header("Forças")]
    [Range(50f,150f)] [Tooltip("Aqui trocamos a força de subir")]
    public float force;

    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start() {
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && !isDead){
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(Vector2.up * force);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        isDead = true;
        rb2d.velocity = Vector2.zero;

    }
}
