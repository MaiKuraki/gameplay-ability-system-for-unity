﻿using UnityEngine;

namespace GAS.Runtime
{
    [CreateAssetMenu(fileName = "ScalableFloatModCalculation", menuName = "GAS/MMC/ScalableFloatModCalculation")]
    public class ScalableFloatModCalculation:ModifierMagnitudeCalculation
    {
        [SerializeField] private float k;
        [SerializeField] private float b;

        public override float CalculateMagnitude(GameplayEffectSpec spec,float input)
        {
            return input * k + b;
        }
    }
}