using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(StartMenu(2.5f));
    }
    IEnumerator StartMenu(float value)
    {
        yield return new WaitForSeconds(value);
        SceneManager.LoadScene(1);
    }
}
