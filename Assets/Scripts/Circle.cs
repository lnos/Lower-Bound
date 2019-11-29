using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle : MonoBehaviour
{

    private LevelManager lm;
    public AudioClip clip;
    public AudioSource source;

    public Text scoreText;
    private int score;

    private void Start()
    {
        lm = FindObjectOfType<LevelManager>();
        source.clip = clip;
        score = 0;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            source.Play();
        }

        score += 1;
        scoreText.text = score.ToString();
    }

    private void OnBecameInvisible()
    {
        lm.Gameover();
    }

}
