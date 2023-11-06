using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    float Current { get; }
    void Increase(float value);
    
    void Decrease(float value);
}
