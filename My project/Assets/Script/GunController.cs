using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
     public GameObject bullet;

    private void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            var rayDistance = ray.direction;

            var instanceBullet = Instantiate(bullet);

            instanceBullet.transform.position = this.transform.position;
            instanceBullet.GetComponent<BulletController>().Shot(rayDistance.normalized * 3000);
        }
    }

}
