using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform gameOverPanel;
    public List<Transform> items;
    public Text scoreText;
    int score;
    AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = transform.GetComponent<AudioSource>();
        gameOverPanel.gameObject.SetActive(false);
        scoreText.text = "" + 0;
        score = 0;
        for(int i = 0; i < items.Count; i++)
        {
            items[i].gameObject.SetActive(true);
            items[i].GetComponent<item>().manager = this;
        }
    }

   public int AddScore()
    {
        audioSrc.Play();
        score++;
        scoreText.text = "" + score; 
        Debug.Log("Puntuación: " + score);
        

        if(score == items.Count)
        {
            gameOverPanel.gameObject.SetActive(true);
        }
        return score;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("UFOGame");
    }


}
