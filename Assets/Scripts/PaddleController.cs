using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update
     public float speed;
     public KeyCode upKey;
     public KeyCode downKey;
     private Rigidbody2D rig;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //ambil input
        //gerakan ibject pake input
        MoveObject(GetInput());
        
    }
    private Vector2 GetInput()
    {
            // Vector2 movement = Vector2.zero;

        if (Input.GetKey(upKey))
        {
            //gerakan ke atas
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            //gerakan ke bawah
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

        private void MoveObject(Vector2 movement)
        {
            Debug.Log("Kecepatan: "+ movement);
            rig.velocity = movement;

        }

        public void ActivatePSpeed(float magnitude, float duration)
        {
            speed *= magnitude;
            StartCoroutine(SpeedTimer (magnitude, duration));
        }

        public void DeactivatePSpeed(float magnitude)
        {
            speed /= magnitude;
            
        }

        public void ActivatePScale(float multiplier, float duration)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*multiplier, transform.localScale.z);
            StartCoroutine(ScaleTimer (multiplier, duration));
        }

        public void DeactivatePScale(float multiplier)
        {
          transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y/multiplier, transform.localScale.z);
        }

        IEnumerator SpeedTimer(float magnitude, float duration)
        {
            yield return new WaitForSeconds(duration);
            DeactivatePSpeed(magnitude);
        }

        IEnumerator ScaleTimer(float multiplier, float duration)
        {
            yield return new WaitForSeconds(duration);
            DeactivatePScale(multiplier);
        }



}
