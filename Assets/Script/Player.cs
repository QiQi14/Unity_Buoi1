using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D player;
    [SerializeField]
    TextMeshPro textMesh;
    [SerializeField]
    SpriteRenderer eat;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            player.velocity = Vector2.up * 5f;
        }
        if (transform.position.y < -10f)
        {
            textMesh.text = "Game Over";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        textMesh.text = collision.gameObject.tag;
        if (collision.gameObject.tag == "Eat")
        {
            Debug.Log("Da An");
            SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = eat.color;
            Destroy(collision.gameObject);
        }
    }
}
