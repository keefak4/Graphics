using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpFunc : MonoBehaviour
{
    private Vector3 targetPos;
    private void Start()
    {
        targetPos = transform.position + Vector3.right * 10;
    }
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime);
    }
}
