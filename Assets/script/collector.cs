using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ghost")|| collision.CompareTag("white_player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
