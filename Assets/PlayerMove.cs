using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーのワールド座標を取得
        Vector3 pos = transform.position;

        // 右矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += 0.01f;
        }

        // 左矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= 0.01f;
        }

        // 上矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.z += 0.01f;
        }

        // 下矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.z -= 0.01f;
        }

        transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
