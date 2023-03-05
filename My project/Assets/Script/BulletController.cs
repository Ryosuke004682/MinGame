using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public void Shot(Vector3 direction)
    {
        GetComponent<Rigidbody>().AddForce(direction);
    }
}
