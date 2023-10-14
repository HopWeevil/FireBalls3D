using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(ParticleSystemRenderer))]
public class BreakEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private ParticleSystemRenderer _particleSystemRenderer;
    [SerializeField] private AnimationCurve _sizeCurve;
    [SerializeField] private float _sizeMultiplayer;

    private ParticleSystem.MainModule _mainModule;
    private ParticleSystem.SizeOverLifetimeModule _sizeOverLifetimeModule;

    public void Play(Transform towerElement, Color color, Mesh mesh)
    {
        _mainModule = _particleSystem.main;
        _sizeOverLifetimeModule = _particleSystem.sizeOverLifetime;
        _mainModule.startColor = color;
        _mainModule.startRotationY = towerElement.eulerAngles.y * Mathf.Deg2Rad;
        _mainModule.startSizeX = towerElement.localScale.x;
        _mainModule.startSizeZ = towerElement.localScale.z;
        _sizeOverLifetimeModule.size = new ParticleSystem.MinMaxCurve(_sizeMultiplayer, _sizeCurve);
        _particleSystemRenderer.mesh = mesh;
        _particleSystem.Play();
    }
}