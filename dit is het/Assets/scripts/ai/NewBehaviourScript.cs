
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireObject : MonoBehaviour
{
    public GameObject Bullet;
    public float damage = 10f;

    public float Force=2000f;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject BulletHolder;
            BulletHolder = Instantiate(Bullet,transform.position,transform.rotation)as GameObject;
            BulletHolder.transform.Rotate(Vector3.left*90);

            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody=BulletHolder.GetComponent<Rigidbody>();
            Temporary_RigidBody.AddForce(transform.forward*Force);
            Destroy(BulletHolder,2.0f);
        }
    }
}