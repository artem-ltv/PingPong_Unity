using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRackets : MonoBehaviour
{
    public GameObject ball;
    public Transform racketBottom;
    public Transform racketTop;
    public SpriteRenderer spriteRacketBottom;
    public SpriteRenderer spriteRacketTop;
    public float speedRacket = 10f;
    private void OnMouseDrag()
    {
        Vector3 lastPosition = racketTop.position;
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position.x = position.x > 1.95f ? 1.95f : position.x;
        position.x = position.x < -1.95f ? -1.95f : position.x;
        racketTop.position = Vector2.MoveTowards(racketTop.position, new Vector2(position.x, racketTop.position.y), speedRacket*Time.deltaTime);
        racketBottom.position = Vector2.MoveTowards(racketBottom.position, new Vector2(position.x, racketBottom.position.y), speedRacket * Time.deltaTime);
        if (position.x > lastPosition.x)
        {
            spriteRacketBottom.flipX = true;
            spriteRacketTop.flipX = true;
        }
        if (position.x < lastPosition.x)
        {
            spriteRacketBottom.flipX = false;
            spriteRacketTop.flipX = false;
        }
    }
    private void Start()
    {
        ball.SetActive(false);
        StartCoroutine(ActiveBall(2f));
    }
    private IEnumerator ActiveBall(float value)
    {
        yield return new WaitForSeconds(value);
        ball.SetActive(true);
    }
}
