using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlayScript : MonoBehaviour
{
    public GameObject blackBackground;
    private void OnMouseUpAsButton()
    {
        SceneManager.LoadScene(2);
    }
    private void Start()
    {
        blackBackground.GetComponent<Animation>().Play();
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
