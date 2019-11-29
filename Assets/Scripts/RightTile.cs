using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTile : MonoBehaviour
{
    private bool shrink = false;
    public AudioClip clip;
    public AudioSource source;

    private void Start()
    {
        source.clip = clip;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        source.Play();
        if (collision.gameObject.tag == "circle" && !shrink)
        {
            shrink = true;
        }

        collision.rigidbody.velocity = Vector2.zero;
        collision.rigidbody.AddForce(new Vector2(200, 200));
    }

    private void Update()
    {
        if (shrink)
        {
            Shrink();
        }
    }

    public void Shrink()
    {
        if (gameObject.transform.localScale.y > 0)
        {
            gameObject.transform.localScale -= Vector3.one * Time.deltaTime * 0.07f;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
