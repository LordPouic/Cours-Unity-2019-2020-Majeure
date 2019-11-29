﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeScript : MonoBehaviour
{
    [SerializeField]
    private int CurrentLife;

    private int MaxLife;

    private void Start()
    {
        MaxLife = CurrentLife;
    }

    public void UpdateLife(int nb)
    {
        CurrentLife += nb;

        if (CurrentLife <= 0)
        {
            Death();
        }
    }

    public abstract void Death();

    public abstract void End();
  
}
