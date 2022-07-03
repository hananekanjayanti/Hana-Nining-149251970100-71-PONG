using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball,paddleKiri, paddleKanan;
    public float multiplier, duration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision==ball)
        {
            if(ball.GetComponent<BallController>().PaddleLeft() == true)
            {
                paddleKiri.GetComponent<PaddleController>().ActivatePSpeed(multiplier, duration);
                manager.RemovePowerUp(gameObject);
            }
            else
            {
                paddleKanan.GetComponent<PaddleController>().ActivatePSpeed(multiplier, duration);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
