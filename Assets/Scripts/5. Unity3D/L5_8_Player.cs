using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_8_Player : MonoBehaviour
{
    public static L5_8_Player Instance;
    public int AttackValue = 100;
    public List<L5_8_Enemy> enemies;
    private bool isOver = false;
    private int score = 0;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit raycastHit, 1000))
        {
            Debug.DrawLine(ray.origin, raycastHit.point, Color.red);

            // 如果射击到敌人，则附加伤害
            if (raycastHit.collider.gameObject.CompareTag("Enemy"))
            {
                L5_8_Enemy enemy = raycastHit.collider.gameObject.GetComponent<L5_8_Enemy>();
                enemy.Hurt(AttackValue);
            }
        }
    }

    public void EnemyDead(L5_8_Enemy enemy)
    {
        score += 1;
        L5_8_UIManager.Instance.UpdateScoreNumber(score);
        enemies.Remove(enemy);

        if (enemies.Count == 0)
        {
            Win();
        }
    }

    private void Win()
    {
        L5_8_UIManager.Instance.GameResult(true);
    }

    private void Over()
    {
        isOver = true;
        Time.timeScale = 0;
        L5_8_UIManager.Instance.GameResult(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && !isOver)
        {
            Over();
        }
    }
}
