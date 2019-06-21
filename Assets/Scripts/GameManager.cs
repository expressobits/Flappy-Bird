using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    private AudioSource audioSource;

    public bool gameOver;
    private int score;
    public Text gameOverText;
    public Text scoreText;

    public float groundSpeed;


    private void Awake()
    {


        if (!instance)
        {
            audioSource = GetComponent<AudioSource>();
            instance = this;
        }
        else if (instance != this) Destroy(gameObject);
    }

    private void Start()
    {
        gameOver = false;
        score = 0;
    }

    private void Update()
    {

        //SE estiver em gameover e apertar o botao do mouse
        //FAZ iniciar cena

        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }


    public void GameOver()
    {

        gameOver = true;
        gameOverText.gameObject.SetActive(true);

    }

    public void BirdScore()
    {
        if (gameOver)
            return;

        score++;
        scoreText.text = "score: " + score;
        audioSource.Play();
    }


}
