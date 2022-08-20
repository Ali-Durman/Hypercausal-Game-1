using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwerveMove : MonoBehaviour
{
    private PlayerSwerve _swerveInputSystem;
    [SerializeField] private float swervespeed = 0.5f;
    [SerializeField] private float maxSwerveAmount = 1f;

    private void Awake()
    {
        _swerveInputSystem = GetComponent<PlayerSwerve>();
    }

    private void Update()
    {
        float swerveAmount = Time.deltaTime * swervespeed * _swerveInputSystem.moveFactorX;
        swerveAmount = Mathf.Clamp(value: swerveAmount, min:-maxSwerveAmount, maxSwerveAmount);
        transform.Translate(swerveAmount, 0, 0);
    }
}
