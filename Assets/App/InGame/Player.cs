using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Bullet bullet;

    [SerializeField]
    private float shotInterval = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shot());
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    IEnumerator Shot()
    {
        while(true)
        {
            bullet.transform.position = this.transform.position;
            Instantiate(bullet);
            yield return new WaitForSeconds(shotInterval);
        }
    }

    private void Move()
    {
        // 左に移動
        if (Input.GetKey (KeyCode.A)) {
            this.transform.Translate (-0.1f, 0.0f, 0.0f);
        }
        // 右に移動
        if (Input.GetKey (KeyCode.D)) {
            this.transform.Translate (0.1f, 0.0f, 0.0f);
        }
        // 上に移動
        if (Input.GetKey (KeyCode.W)) {
            this.transform.Translate (0.0f ,0.1f, 0.0f);
        }
        // 下に移動
        if (Input.GetKey (KeyCode.S)) {
            this.transform.Translate (0.0f, -0.1f, 0.0f);
        }
    }
}
