using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorFun : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 targetPos;

    private void Start()
    {
        startPos = transform.position;
        targetPos = transform.position + Vector3.right * 10;
        StartCoroutine(CorFunAnim());
    }
    private IEnumerator CorFunAnim()
    {
        for (float i = 0; i < 1; i+=Time.deltaTime/5)
        {
            transform.position = Vector3.Lerp(startPos, targetPos, i);
            yield return null;
        }
       
    }
}
