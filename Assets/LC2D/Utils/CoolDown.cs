using System;
using UnityEngine;

[Serializable]

public class CoolDown
{ 
    [SerializeField] private float value;

    private float _timesUp;

    public void Reset()
    {
        _timesUp = Time.time + value;
    }

    public bool IsReady => _timesUp <= Time.time;
}
