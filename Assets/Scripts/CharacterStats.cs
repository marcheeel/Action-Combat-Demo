using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public string characterName;

    public float strenght;
    public GameObject attackZone;

    public float magic;
    public GameObject abilityZone;
    public float abilityCooldown;

    private void Start()
    {
        strenght = 10;
        magic = 25;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            NormalAttack();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Ability();
        }
    }

    public void NormalAttack()
    {
        attackZone.SetActive(true);
    }

    public void Ability()
    {
        abilityZone.SetActive(true);
    }
}