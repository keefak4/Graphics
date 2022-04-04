using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWFunc : MonoBehaviour
{
    private Vector3 targetPos;
    private float time;
    private void Start()
    {
        targetPos = transform.position + Vector3.right * 10;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, time);
        time += Time.deltaTime;
    }
}
