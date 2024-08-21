using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacles : MonoBehaviour
{
    public int maxLives = 3;
    private int currentLives;
    public Image[] livesImages;
    public GameObject gameOverPanel;

    private void Start()
    {
        currentLives = maxLives;

        UpdateLivesUI();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            Debug.Log("çarptýn");
            TakeDamage();
        }
    }

    void TakeDamage()
    {
        if (currentLives > 0)
        {
            currentLives--;
            UpdateLivesUI();
        }

        if (currentLives <=0)
        {
            gameOverPanel.SetActive(true);
        }
    }

    void UpdateLivesUI()
    {
        for (int i = 0; i < livesImages.Length; i++)
        {
            if (i < currentLives)
            {
                livesImages[i].enabled = true;
            }

            else
            {
                livesImages[i].enabled = false;
            }
        }
    }
}
