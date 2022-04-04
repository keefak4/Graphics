using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCurFun : MonoBehaviour
{
   [SerializeField] private AnimationCurve Curve;
    private Vector3 startPos;
    private Vector3 targetPos;
    private void Start()
    {
        startPos = transform.position;
        targetPos = transform.position + Vector3.right * 10;
        StartCoroutine(CorCurve());
    }
    private IEnumerator CorCurve()
    {
        for (float i = 0; i < 1; i += Time.deltaTime)
        {
            transform.position = Vector3.Lerp(startPos,targetPos,Curve.Evaluate(i));
            yield return null;
        }
    }
}
