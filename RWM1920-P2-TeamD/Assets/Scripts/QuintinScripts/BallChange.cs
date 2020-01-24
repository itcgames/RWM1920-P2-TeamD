using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallChange : MonoBehaviour
{
    public static int ballNum;
    public SpriteRenderer ballSprite;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(ballNum < 1)
        {
            ballNum = 5;
        }
        else if (ballNum > 5)
        {
            ballNum = 1;
        }
        switch (ballNum)
        {
            case 1:
                ballSprite.sprite = sprite1;
                break;
            case 2:
                ballSprite.sprite = sprite2;
                break;
            case 3:
                ballSprite.sprite = sprite3;
                break;
            case 4:
                ballSprite.sprite = sprite4;
                break;
            case 5:
                ballSprite.sprite = sprite5;
                break;
        };
    }
    public void right()
    {
        ballNum++; Debug.Log("q");
    }
    public void left()
    {
        ballNum--; Debug.Log("w");
    }
}
