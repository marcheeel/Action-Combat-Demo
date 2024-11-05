using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    public float actualHP;
    public float maxHP;

    public Image healthBar;

    private void Start()
    {
        actualHP = maxHP;
    }

    public void TakeDamage(float amount)
    {
        actualHP -= amount;
        healthBar.fillAmount = actualHP / maxHP;
        Debug.Log("Losed HP: " + amount);
    }
}