using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class Control2D : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private Text scoreText;
    private int score = 0;

    public int ScoreGet
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }




    void Update()
    {
        float movement = Input.GetAxis("Horizontal") * playerSpeed;

        transform.position = new Vector2(movement, transform.position.y);

        PlayerPrefs.SetInt("score", score);
        scoreText.text = "Score: " + score.ToString();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        score += 1;
    }
}
