using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    public TMP_Text counter;

    private void Start()
    {
        counter.text = "Time Played: " + PlayerPrefs.GetFloat("Time");
    }
}

