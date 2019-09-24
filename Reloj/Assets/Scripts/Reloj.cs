using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloj : MonoBehaviour

{

    const float gradosHoras = 30f, gradosMinutos = 6f, gradosSegundos = 6f;

    public bool movimientoContinuo;
    public Transform horasTransform, minutosTransform, segundosTransform;

    void Awake()
    {
        UpdateDiscreto();
    }

    void Update()
    {
        if (movimientoContinuo)
        {
            UpdateContinuo();
        }
        else
        {
            UpdateDiscreto();
        }
    }

    void UpdateContinuo()
    {
        TimeSpan dateTime = DateTime.Now.TimeOfDay;

        horasTransform.localRotation = Quaternion.Euler(0f, (float)dateTime.TotalHours * gradosHoras, 0f);
        minutosTransform.localRotation = Quaternion.Euler(0f, (float)dateTime.TotalMinutes * gradosMinutos, 0f);
        segundosTransform.localRotation = Quaternion.Euler(0f, (float)dateTime.TotalSeconds * gradosSegundos, 0f);
    }

    void UpdateDiscreto()
    {
        DateTime dateTime = DateTime.Now;

        horasTransform.localRotation = Quaternion.Euler(0f, dateTime.Hour * gradosHoras, 0f);
        minutosTransform.localRotation = Quaternion.Euler(0f, dateTime.Minute * gradosMinutos, 0f);
        segundosTransform.localRotation = Quaternion.Euler(0f, dateTime.Second * gradosSegundos, 0f);
    }
}
