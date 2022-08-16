using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    [Header("Amounts")]
    public int totalWood;
    public int carrots;
    public float currentWater;
    public int fishes;
    
    [Header("Limits")]
    private float _waterLimit = 50;
    private float _carrotsLimit = 10;
    private float _woodLimit = 10;
    private float _fishesLimit = 3f;

    public float waterLimit { get => _waterLimit; set => _waterLimit = value; }
    public float carrotsLimit { get => _carrotsLimit; set => _carrotsLimit = value; }
    public float woodLimit { get => _woodLimit; set => _woodLimit = value; }
    public float fishesLimit { get => _fishesLimit; set => fishesLimit = value; }

    public void WaterLimit(float water)
    {
        if (currentWater < 50)
        {
            currentWater += water;
        }

    }
}
