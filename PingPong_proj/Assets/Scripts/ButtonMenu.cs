using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMenu : MonoBehaviour
{
    public GameObject blackBackground;
    public Text score;
    public Text record;
    private void OnMouseUpAsButton()
    {
        blackBackground.SetActive(true);
        score.enabled = false;
        record.enabled = false;
        blackBackground.GetComponent<Animation>().Play();
        StartCoroutine(GoToMenu(1f));
    }
    private IEnumerator GoToMenu(float value)
    {
        yield return new WaitForSeconds(value);
        SceneManager.LoadScene(1);
    }
}
