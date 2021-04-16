using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSettingsScript : MonoBehaviour
{
    public GameObject ballColorSettings;
    public GameObject buttonPlay;
    public GameObject buttonSettings;
    public GameObject buttonAny1;
    public GameObject buttonAny2;
    private void OnMouseUpAsButton()
    {
        ballColorSettings.SetActive(true);
        buttonPlay.SetActive(false);
        buttonSettings.SetActive(false);
        buttonAny1.SetActive(false);
        buttonAny2.SetActive(false);
    }
    public void OnMouseDown()
    {
        transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
    }
    public void OnMouseUp()
    {
        transform.localScale = new Vector3(0.65f, 0.65f, 0.65f);
    }
}
