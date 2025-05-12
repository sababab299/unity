using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawnPosition;
    public float shootForce = 500;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bulletClone = Instantiate(bullet, bulletSpawnPosition.position, Quaternion.identity);
            bulletClone.GetComponent<MeshRenderer>().material.color = Color.blue;
            bulletClone.GetComponent<Rigidbody>()
                .AddForce(transform.forward * shootForce);
        }
    }
}
