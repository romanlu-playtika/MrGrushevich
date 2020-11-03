using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public enum ParticleType
    {
        Main,
        Waves,
        Points,
    }

    [SerializeField] private ParticleSystem mainParticle;
    [SerializeField] private ParticleSystem wavesParticle;
    [SerializeField] private ParticleSystem pointsParticle;

    [SerializeField] private ParticleType particleType;

    [SerializeField] private float minLifeTime = 0.2f;
    [SerializeField] private float maxLifeTime = 1f;

    [SerializeField] private int minRate = 100;
    [SerializeField] private int maxRate = 200;

    [ContextMenu("Play")]
    private void Play()
    {
        mainParticle.Play();
        wavesParticle.Play();
        pointsParticle.Play();
    }
    [ContextMenu("Stop")]
    private void Stop()
    {
        mainParticle.Stop();
        wavesParticle.Stop();
        pointsParticle.Stop();
    }
    [ContextMenu("Pause")]
    private void Pause()
    {
        mainParticle.Pause();
        wavesParticle.Pause();
        pointsParticle.Pause();
    }
    void Update()
    {
        switch (particleType)
        {
            case ParticleType.Main:
                UpdateParticle(mainParticle);
                break;
            case ParticleType.Waves:
                UpdateParticle(wavesParticle);
                break;
            case ParticleType.Points:
                UpdateParticle(pointsParticle);
                break;
        }
    }

    private void UpdateParticle(ParticleSystem system)
    {
        var main = system.main;
        main.startLifetime = new ParticleSystem.MinMaxCurve(minLifeTime, maxLifeTime);

        var emission = system.emission;
        emission.rateOverTime = new ParticleSystem.MinMaxCurve(minRate, maxRate);
    }
}
