using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D Player;
    float horizotal , vertical;
    private bool isFacingright = true;
    SpriteRenderer image;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
        image = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizotal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizotal, vertical) * speed;
        Player.velocity = movement;
        
        if ( horizotal < 0 )
        {
            image.flipX = true;
            isFacingright = false;
            
        }
        else if ( horizotal > 0)
        {
            image.flipX = false;
            isFacingright = true;
            
        }


    }
    
    public void FlipFace()
    {
        isFacingright = !isFacingright;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }


}
