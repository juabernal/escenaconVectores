using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    enum EnemyTypes { enemy1,enemy2};
    [SerializeField] EnemyTypes enemytype;

    [SerializeField] Transform playerTransform;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (enemytype)
        {
            case EnemyTypes.enemy1:
                EnemyTeSigue();
                break;
            case EnemyTypes.enemy2:
                RotateAroundPlayer();
                break;
        }
    }

    private void LookAt()
    {
        transform.LookAt(playerTransform);
    }

    private void EnemyTeSigue()
    {
        LookAt();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 2f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
        
    }
    private void RotateAroundPlayer()
    {
        LookAt();
        transform.RotateAround(playerTransform.position, Vector3.up, 20f * Time.deltaTime);
    }
}
