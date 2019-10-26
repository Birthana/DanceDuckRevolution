using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public RectTransform bar;

    int damage = 10;
    int maxHealth = 100;
    int currentHealth;
    float[] Dimensions = { 50, 340 };
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
    }
}
