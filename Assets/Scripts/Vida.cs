using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int maxLives = 6;
    public int currentLives;

    private void Start()
    {
        currentLives = maxLives;
    }

    public void TakeDamage(int damageAmount)
    {
        currentLives -= 1;
        if (currentLives <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Heal(int healAmount)
    {
        currentLives += healAmount;

        currentLives = Mathf.Min(currentLives, maxLives);
    }
}
