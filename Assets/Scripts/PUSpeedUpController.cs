using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude, duration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            StartCoroutine( PowerUp(collision)); 
        }

    }
    IEnumerator PowerUp(Collider2D ball)
    {
        ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;

        yield return new WaitForSeconds(duration);

        ball.GetComponent<BallController>().DeactivatePUSpeedUp(magnitude);
        manager.RemovePowerUp(gameObject);


    }
}
