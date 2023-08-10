using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_0_script : MonoBehaviour
{
    public float speed;
    private Rigidbody2D obj1;
    void Awake()
    {
        obj1 = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        obj1.velocity = new Vector2(speed, obj1.velocity.y);
    }
}
