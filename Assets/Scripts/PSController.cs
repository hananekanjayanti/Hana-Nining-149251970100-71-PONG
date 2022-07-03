using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSController : MonoBehaviour
{
   public PowerUpManager manager;
   public Collider2D ball, paddleKiri, paddleKanan;
   public float magnitude, duration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision==ball)
        {
            if(ball.GetComponent<BallController>().PaddleLeft() == true)
            {
                paddleKiri.GetComponent<PaddleController>().ActivatePSpeed(magnitude, duration);
                manager.RemovePowerUp(gameObject);
            }
            else
            {
                paddleKanan.GetComponent<PaddleController>().ActivatePSpeed(magnitude, duration);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
