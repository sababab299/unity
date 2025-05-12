using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject originalGameObject;
    public Transform parentTransform;
    void Start()
    {
        GameObject cloneGameobject = Instantiate(
            originalGameObject,
            spawnPosition.position,
            Quaternion.identity);
        cloneGameobject.transform.parent = parentTransform;
    }
}
