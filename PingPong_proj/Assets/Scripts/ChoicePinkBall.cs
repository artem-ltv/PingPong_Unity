using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicePinkBall : MonoBehaviour
{
    public GameObject choiceGreen;
    public GameObject choiceWhite;
    public GameObject choicePink;
    private void OnMouseUp()
    {
        PlayerPrefs.SetInt("Color", 3);
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Color") == 3)
        {
            choiceGreen.SetActive(false);
            choiceWhite.SetActive(false);
            choicePink.SetActive(true);
        }
    }
}
