﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PindahHalaman(string halaman)
    {
        SceneManager.LoadScene(halaman);
    }

    public void KeluarAplikasi()
    {
        Application.Quit();
    }
}
