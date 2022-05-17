using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot : MonoBehaviour
{
    public Transform mFootMesh;

    private void Update()
    {
        mFootMesh.position = Vector3.Lerp(mFootMesh.position, transform.position, Time.deltaTime * 15.0f);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(!collision.gameObject.CompareTag("Ball"))
    //    {
    //        return;
    //    }
    //    if (collision.gameObject.CompareTag("Ball"))
    //    {
    //        collision.gameObject.SetActive(false);
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (!other.gameObject.CompareTag("Ball"))
    //    {
    //        return;
    //    }
    //    if (other.gameObject.CompareTag("Ball"))
    //    {
    //        other.gameObject.SetActive(false);
    //    }
    //}
}
