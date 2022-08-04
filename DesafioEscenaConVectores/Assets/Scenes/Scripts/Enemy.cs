using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAt();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 2f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }  
    }

    private void LookAt()
    {
        transform.LookAt(playerTransform);
    }


}

