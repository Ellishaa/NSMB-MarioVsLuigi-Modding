using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOriginalPosition : MonoBehaviour
{
    public Vector3 originalPosition;
    void Awake()
    {
        originalPosition = this.gameObject.transform.position;
    }

}
