﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class letitgo_btn : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("letitgo");
    }
}
