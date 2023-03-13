using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public void Shot(Vector3 direction)
    {
        GetComponent<Rigidbody>().AddForce(direction);
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Target"))
        {
            Destroy(other.gameObject);
        }
    }

}

