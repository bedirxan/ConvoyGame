﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class retMenu : MonoBehaviour
{
 public void returnToMenu()
    {
        SceneManager.LoadScene("AnaMenu");
    }
}
