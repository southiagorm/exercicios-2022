using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private GameObject lightingPrefab;

    private float xMax = 8.0f;

    private float shootTime;
    [SerializeField]
    private float shootRate;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(transform.position.x >= 8)
        {
            xMax = -8;
        }else if(transform.position.x <= -8)
        {
            xMax = 8;
        }
        Vector2 target = new Vector2(xMax, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        Shoot();
    }

    void Shoot()
    {
        shootTime += Time.deltaTime;
        if (shootTime >= shootRate)
        {
            Instantiate(lightingPrefab, transform.position, transform.rotation);
            shootTime = 0;
        }
    }
}
