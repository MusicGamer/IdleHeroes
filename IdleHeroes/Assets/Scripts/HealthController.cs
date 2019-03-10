using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public CharacterData characterData;

    public void TakeDamag(float damage)
    {
        characterData.health -= damage;

        if (characterData.health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
