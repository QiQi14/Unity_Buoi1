using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    Transform player;

    // Update is called once per frame
    void Update()
    {
        if (player.position.y > transform.position.y)
        {
            transform.position = new Vector3(0F, player.position.y, player.position.z - 1);
        }
    }
}
