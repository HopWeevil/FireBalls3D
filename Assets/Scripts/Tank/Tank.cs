using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Projectile _projectileTemplate;
    [SerializeField] private float _shootDelay;
    [SerializeField] private float _recoilDistance;

    private float _timeAfterShoot;

    private void Update()
    {
        _timeAfterShoot += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (_timeAfterShoot > _shootDelay)
            {
                Shoot();
                Recoil();
                _timeAfterShoot = 0;
            }
        }
    }

    private void Shoot()
    {
        Instantiate(_projectileTemplate, _shootPoint.position, Quaternion.identity);
    }

    private void Recoil()
    {
        transform.DOMoveZ(transform.position.z - _recoilDistance, _shootDelay / 2).SetLoops(2, LoopType.Yoyo);
    }
}