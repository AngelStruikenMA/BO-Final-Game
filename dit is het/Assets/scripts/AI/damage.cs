using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int DMG;
    float cooldown = 0f;
    private void OnCollisionEnter(Collision collision)
    {
        PlayerHealth health= collision.gameObject.GetComponent<PlayerHealth>();
        if (health != null)
        {
            health.TakeDamage(DMG);
        }
    }
}
