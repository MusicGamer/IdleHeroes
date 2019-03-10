using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public CharacterData characterData;
    public string isEnemy;
    private Transform target;
    private HealthController enemyHC;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag(isEnemy).GetComponent<Transform>();
        enemyHC = target.GetComponent<HealthController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, target.position) > 1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, characterData.speed * Time.deltaTime);
        }
        else
        {
            Atack();
        }
    }

    private void Atack()
    {
        enemyHC.TakeDamag(characterData.damage);
    }
}
