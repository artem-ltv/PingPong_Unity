using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceWhiteBall : MonoBehaviour
{
    public GameObject choiceGreen;
    public GameObject choiceWhite;
    public GameObject choicePink;
    private void OnMouseUp()
    {
        PlayerPrefs.SetInt("Color", 2);
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Color") == 2)
        {
            choiceGreen.SetActive(false);
            choiceWhite.SetActive(true);
            choicePink.SetActive(false);
        }
    }
}
