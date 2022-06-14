using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_8_Enemy : MonoBehaviour
{
    public int HP = 100;

    //private static int _count = 0;

    private Rigidbody _rigidbody;
    private float speed = 4;

    //static L5_8_Enemy()  // 这种方法在 Unity 中不能获得实际数量
    //{
    //    _count += 1;
    //    print(_count);
    //}

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        // forward 是当前的前方
        Vector3 offset = transform.forward * Time.fixedDeltaTime * speed;
        _rigidbody.MovePosition(transform.position + offset);
    }

    public void Hurt(int damage)
    {
        HP -= damage;
        if (HP <= 0)
        {
            Dead();
        }
    }

    private void Dead()
    {
        L5_8_Player.Instance.EnemyDead(this);
        Destroy(gameObject);
    }
}
