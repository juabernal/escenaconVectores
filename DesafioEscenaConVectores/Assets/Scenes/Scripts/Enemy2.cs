using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateAroundPlayer();

    }
    private void LookAt()
    {
        transform.LookAt(playerTransform);
    }

    private void RotateAroundPlayer()
    {
        LookAt();
        transform.RotateAround(playerTransform.position, Vector3.up, 20f * Time.deltaTime);
    }
}
