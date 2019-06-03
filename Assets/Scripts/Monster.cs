using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : CharacterData
{
    public override void DestroyCall()
    {
        PlayManager.Instance.InstantiateDropBox(transform.position);

        Destroy(gameObject);
    }

}
