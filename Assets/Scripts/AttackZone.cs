using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackZone : MonoBehaviour
{
    public CharacterStats actualCharacter;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Crea una lista para almacenar los enemigos alcanzados
            List<EnemyStats> reachedEnemies = new();

            // Obtiene el componente EnemyStats del objeto
            EnemyStats enemyStats = other.GetComponent<EnemyStats>();

            // Si el componente EnemyStats no es nulo
            if (enemyStats != null)
            {
                // Añade el enemigo a la lista
                reachedEnemies.Add(enemyStats);

                // Llama a la función TakeDamage del enemigo con la fuerza del personaje actual
                enemyStats.TakeDamage(actualCharacter.strenght);
            }

            Debug.Log("Physical Attack");

            // Vacía la lista de enemigos alcanzados
            reachedEnemies.Clear();
            actualCharacter.attackZone.SetActive(false);
        }

        actualCharacter.attackZone.SetActive(false);
    }
}