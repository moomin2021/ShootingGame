using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // --Enemy�̗̑͗p�ϐ�-- //
    private int enemyHp;

    // Start is called before the first frame update
    void Start()
    {
        // --�������ɑ̗͂��w�肵�Ă���-- //
        enemyHp = 3;
        Debug.Log("Enemy�N��");
    }

    // Update is called once per frame
    void Update()
    {
        // --�����̗͂�0�ȉ��ɂȂ�����-- //
        if (enemyHp <= 0)
        {
            // --�����ŏ�����
            Destroy(this.gameObject);
        }
    }

    // --HP�����炷����-- //
    public void Damege()
    {
        enemyHp = enemyHp - 1;
    }
}