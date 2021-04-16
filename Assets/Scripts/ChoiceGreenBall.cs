using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceGreenBall : MonoBehaviour
{
    public GameObject choiceGreen;
    public GameObject choiceWhite;
    public GameObject choicePink;
    private void OnMouseUp()
    {
        PlayerPrefs.SetInt("Color", 1);
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Color") == 1)
        {
            choiceGreen.SetActive(true);
            choiceWhite.SetActive(false);
            choicePink.SetActive(false);
        }
    }
}
