using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Intro 2");
    }
}
