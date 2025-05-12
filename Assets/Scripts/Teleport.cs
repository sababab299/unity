using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform spawnPosition;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.transform.position = spawnPosition.position;
        }
        Debug.Log(other.gameObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }
}
