using System.Collections;
using UnityEngine;

public class PizzaMovingOven : MonoBehaviour
{
    public Transform targetPosition;
    public float moveDuration = 1f;

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
        StartCoroutine(MoveToTarget());
    }

    private IEnumerator MoveToTarget()
    {
        float elapsedTime = 0f;

        while (elapsedTime < moveDuration)
        {
            float t = elapsedTime / moveDuration;
            transform.position = Vector3.Lerp(initialPosition, targetPosition.position, t);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure final position accuracy
        transform.position = targetPosition.position;

        // Coroutine has finished
        Debug.Log("Object reached the target location.");
    }
}
