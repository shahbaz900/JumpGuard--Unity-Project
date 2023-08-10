using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    private Transform player;
    private Vector3 ptr;
    [SerializeField]
    public float maxX, minX;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("white_player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player != null)
        { 
            ptr = transform.position;
            ptr.x = player.position.x;
            if (ptr.x < minX)
            {
                ptr.x = minX;
            }
            if (ptr.x > maxX)
            {
                ptr.x = maxX;
            }
            transform.position = ptr;
        }
    }
}
