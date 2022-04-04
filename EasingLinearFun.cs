using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasingLinearFun : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 targetPos;
    private float time;
    private void Start()
    {
        startPos = transform.position;
        targetPos = transform.position + Vector3.right * 10;
    }
    private void Update()
    {
        transform.position = Vector3.Lerp(startPos, targetPos,EasingLinear(time));
        time += Time.deltaTime;
    }
    private float EasingLinear(float x)
    {
        return x;
    }
}
