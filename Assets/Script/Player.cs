using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float jumpSpeed = 10F;
    [SerializeField]
    Rigidbody2D body;
    [SerializeField]
    SpriteRenderer sr;

    [SerializeField]
    string currentColor;

    [SerializeField]
    Color colorCyan;
    [SerializeField]
    Color colorPurple;
    [SerializeField]
    Color colorYellow;
    [SerializeField]
    Color colorMagento;

    private void Start()
    {
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            body.velocity = Vector2.up * jumpSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != currentColor)
            Debug.Log("Game Over!");

        if (collision.tag == "EatYellow")
        {
            SetColor(2);
            Destroy(collision.gameObject);
        }
        Debug.Log(collision.tag);
    }

    private void SetColor(int index)
    {
        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Purple";
                sr.color = colorPurple;
                break;
            case 2:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 3:
                currentColor = "Magento";
                sr.color = colorMagento;
                break;
        }
    }

    private void SetRandomColor()
    {
        int index = UnityEngine.Random.Range(0, 3);
        SetColor(index);
    }
}
