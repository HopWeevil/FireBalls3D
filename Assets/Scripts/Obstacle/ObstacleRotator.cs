using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleRotator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DORotate(new Vector3(90, 360, 0), _duration, RotateMode.FastBeyond360).SetLoops(-1, _loopType);
    }
}
