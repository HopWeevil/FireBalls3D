using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRotator : MonoBehaviour
{
    [SerializeField] private float _degreesPerSecond;

    public void Rotate()
    {
        transform.Rotate(new Vector3(0, _degreesPerSecond, 0) * Time.deltaTime);
    }
}