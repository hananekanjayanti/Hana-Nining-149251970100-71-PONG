using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;

    private bool isPaddleKiri;

    private Rigidbody2D rig;


    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void ResetBall()
    {
        transform.position = new Vector3 (resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;


    }

    public void DeactivatePUSpeedUp(float magnitude)
    {
        rig.velocity /= magnitude;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Paddle Kiri")
        {
            isPaddleKiri = true;
        }
        else if(collision.gameObject.name == "Paddle Kanan")
        {
            isPaddleKiri = false;
        }
    }
     
    public bool PaddleLeft()
    {
        return isPaddleKiri;
    }

   
}
