using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 mMovementDirection = Vector3.zero;
    private Coroutine mCurrentCharger = null;

    private void OnEnable()
    {
        mCurrentCharger = StartCoroutine(DirectionCharger());
    }

    private void OnDisable()
    {
        StopCoroutine(mCurrentCharger);
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
        //Return to Ball Manager
    }

    private void Update()
    {
        //Movement
        //transform.position += mMovementDirection * Time.deltaTime * 0.5f;

        //Rotation
    }

    private IEnumerator DirectionCharger()
    {
        mMovementDirection = new Vector2(Random.Range(0, 100) * 0.01f, Random.Range(0, 100) * 0.01f);
        yield return new WaitForSeconds(3.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Left"))
        {
            Debug.Log("Left!");
            this.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Right"))
        {
            Debug.Log("Right!");
            this.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Up"))
        {
            Debug.Log("Up!");
            this.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Down"))
        {
            Debug.Log("Down!");
            this.gameObject.SetActive(false);
        }
    }
}
