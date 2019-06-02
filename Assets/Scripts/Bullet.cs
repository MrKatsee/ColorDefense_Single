using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float damage;
    float spd;

    Vector3 vec;

    public void Init_Bullet(Vector3 _vec, float _damage, float _spd)
    {
        vec = _vec.normalized;
        damage = _damage;
        spd = _spd;

        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        while(true)
        {
            transform.Translate(vec * spd * Time.deltaTime);

            yield return null;
        }
    }

    public void DestroyCall()
    {
        StopAllCoroutines();
        Destroy(gameObject);
    }

    
}
