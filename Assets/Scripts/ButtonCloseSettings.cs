using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCloseSettings : MonoBehaviour
{
    public GameObject ballColorSettings;
    public GameObject buttonPlay;
    public GameObject buttonSettings;
    public GameObject buttonAny1;
    public GameObject buttonAny2;
    private void OnMouseUpAsButton()
    {
        ballColorSettings.SetActive(false);
        buttonPlay.SetActive(true);
        buttonSettings.SetActive(true);
        buttonAny1.SetActive(true);
        buttonAny2.SetActive(true);
    }
    public void OnMouseDown()
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
    public void OnMouseUp()
    {
        transform.localScale = new Vector3(0.45f, 0.45f, 0.45f);
    }
}
