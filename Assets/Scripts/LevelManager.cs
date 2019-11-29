using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;
    public GameObject left, right, tile;
    public Camera cm;
    public GameObject GameOverUI;
    
    // Start is called before the first frame update
    void Start()
    {
        source.clip = clip;
        InvokeRepeating("SpawnTiles", 0f, 9.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnTiles()
    {
        for(int i = 0; i < 5; i++)
        {
            int dice = Random.Range(1, 4);
            //-2.3, -1.15, 0
            float x = (float)-2.3 + i * 1.15f;

            if(dice == 1)
            {
                Instantiate(tile, new Vector3(x, cm.transform.position.y + 5.2f, 0), transform.rotation);
            }
            else if(dice == 2)
            {
                Instantiate(left, new Vector3(x, cm.transform.position.y + 5.2f, 0), transform.rotation);
            }
            else
            {
                Instantiate(right, new Vector3(x, cm.transform.position.y + 5.2f, 0), transform.rotation);
            }
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }

    public void Gameover()
    {
        GameOverUI.SetActive(true);
        source.Play();
        Time.timeScale = 0f;
    }

}
