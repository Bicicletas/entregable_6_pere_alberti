using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float rotation1 = 180f;
    private float rotation2 = 90f;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, 0));
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, rotation1));
        }
       
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, -rotation2));
        }
       
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, rotation2));
        }
    }

    public void SpawnProjectile(Quaternion rotation)
    {
        Instantiate(projectilePrefab , transform.position, rotation);
    }
}
