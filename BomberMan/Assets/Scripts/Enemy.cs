using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(transform.DOMove(Vector3.left, 0.3f));
        sequence.AppendInterval(0.3f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    
        
}
