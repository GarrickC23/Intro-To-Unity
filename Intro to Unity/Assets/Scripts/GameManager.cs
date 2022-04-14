using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //used for gameOver
    public GameObject gameOverScreen;
    public AudioSource gmAudioSource;

    public AudioClip scoreSound;
    public AudioClip dieSound;

    //Used for points
    public Text scoreText;
    int points = 0;

    public void ScorePoint()
    {
        points += 1;
        scoreText.text = points.ToString();

        gmAudioSource.PlayOneShot(scoreSound);

        Debug.Log("TODO : do stuff when we score a point");
    }

    public void BirdDies()
    {
        Debug.Log("TODO : do stuff when bird dies");

        gmAudioSource.PlayOneShot(dieSound);

        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

}
