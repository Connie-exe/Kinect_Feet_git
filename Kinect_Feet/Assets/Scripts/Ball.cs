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
        transform.position += mMovementDirection * Time.deltaTime * 0.5f;

        //Rotation
    }

    private IEnumerator DirectionCharger()
    {
        mMovementDirection = new Vector2(Random.Range(0, 100) * 0.01f, Random.Range(0, 100) * 0.01f);
        yield return new WaitForSeconds(3.0f);
    }
}
