using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public const float spd = 3f;

    public void Move(Vector3 _vec)
    {
        Vector3 vec = _vec.normalized;

        transform.Translate(vec * spd * MyTime.deltaTime);

        transform.GetChild(0).transform.rotation = Quaternion.LookRotation(vec, Vector3.up);
    }
}
