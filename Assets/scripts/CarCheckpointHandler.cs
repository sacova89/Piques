using UnityEngine;
using System.Collections;

public class CarCheckpointHandler : MonoBehaviour
{
    private Vector3 lastCheckpointPosition;
    private bool isRespawning = false;

    void Start()
    {
        // Establecer la posición inicial del carro como el primer checkpoint
        lastCheckpointPosition = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            // Actualizar la posición del último checkpoint al que se pasó
            lastCheckpointPosition = other.transform.position;
        }
        else if (other.CompareTag("TRAMPA") && !isRespawning)
        {
            // Si el carro toca un objeto con el tag "TRAMPA" y no está en proceso de respawn
            isRespawning = true;
            StartCoroutine(RespawnCarSmoothly()); // Invoca la coroutine para respawnear suavemente
        }
    }

    IEnumerator RespawnCarSmoothly()
    {
        float duration = 2f; // Duración del movimiento suave (2 segundos)
        float elapsed = 0f;
        Vector3 initialPosition = transform.position;

        while (elapsed < duration)
        {
            // Mover suavemente desde la posición actual a la del último checkpoint
            transform.position = Vector3.Lerp(initialPosition, lastCheckpointPosition, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Asegurarse de estar exactamente en la posición del último checkpoint al finalizar el movimiento
        transform.position = lastCheckpointPosition;
        isRespawning = false;
    }
}
