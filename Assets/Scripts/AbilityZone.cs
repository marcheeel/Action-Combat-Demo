using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityZone : MonoBehaviour
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
                enemyStats.TakeDamage(actualCharacter.magic);
            }

            Debug.Log("Magical Attack");

            // Vacía la lista de enemigos alcanzados
            reachedEnemies.Clear();
            actualCharacter.abilityZone.SetActive(false);
        }

        actualCharacter.abilityZone.SetActive(false);
    }
}