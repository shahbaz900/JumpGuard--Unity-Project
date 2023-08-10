using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float moveforce = 10f;
    public float jumpforce = 2.5f;
    private Animator anim;
    private SpriteRenderer sr;
    private Rigidbody2D obj;
    bool isgrounded=true;
    private float moveX;
    string REST_ANIM = "Player-1 Anim";
    string WALK_ANIM = "walk";
    string groundcheck = "Ground_all";
    string ghostcheck = "ghost";
    void Awake()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        obj = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }
    void Update()
    {
        PlayerMovement();
        putanimation();
    }
    private void FixedUpdate()
    {
        playerjump();
    }
    void PlayerMovement()
    {
        anim.Play(REST_ANIM);
        moveX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveX, 0f, 0f) * moveforce * Time.deltaTime;
    }

    void putanimation()
    {
        if(moveX==0)
        {
            anim.Play(REST_ANIM);
        }
        else if (moveX < 0)
        {
            anim.Play(WALK_ANIM);
            sr.flipX = true;
        }
        else
        {
            anim.Play(WALK_ANIM);
            sr.flipX = false;
        }
    }
    void playerjump()
    {
        if(Input.GetButtonDown("Jump")&& isgrounded)
        {
            isgrounded = false;
            obj.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(groundcheck))
        {
            isgrounded = true;
        }
        if(collision.gameObject.CompareTag(ghostcheck))
        {
            Destroy(gameObject);
        }
    }
}
