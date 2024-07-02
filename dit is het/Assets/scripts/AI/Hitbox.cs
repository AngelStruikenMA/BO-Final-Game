using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public Health health;

    public void OnRaycastHit(CustomProjectiles bullet)
    {
       // health.TakeDamage(bullet.damage);
    }
}
