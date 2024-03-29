﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public RectTransform bar;

    int damage = 10;
    int maxHealth = 100;
    int currentHealth;
    float[] Dimensions = { 66, 380 };
    public AudioSource audioDamage;
    public AudioSource audioDeath;
    void Start()
    {
        bar = this.GetComponent<RectTransform>();
        currentHealth = maxHealth;
    }

    public void TakeDamage()
    {
        currentHealth -= damage;
        float scale = (float)currentHealth /maxHealth;
        bar.sizeDelta = new Vector2(Dimensions[0],scale * Dimensions[1]);
        audioDamage.Play();
        if (currentHealth == 0)
        {
            audioDeath.Play();
            SceneManager.LoadScene(3);
        }
    }
    
    public void GainHealth()
    {
        if (currentHealth < 100)
        {
            currentHealth += damage;
            float scale = (float)currentHealth / maxHealth;
            bar.sizeDelta = new Vector2(Dimensions[0], scale * Dimensions[1]);
        }
    }
}
