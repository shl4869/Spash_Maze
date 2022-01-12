using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterEvent : MonoBehaviour
{
    public GameObject[] lifes;
    public GameObject characterObj;
    public Text drawnText;
    public Rigidbody2D rigid;
    public SpriteRenderer sr;

    public int colNum = 0;
    public int rotNum;
    public static bool isGameOver = false;
    public float drawnGauge;
    public float x1, x2;

    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        rotNum = 1;
        drawnGauge = 1000;
        rigid = characterObj.GetComponent<Rigidbody2D>();
        sr = characterObj.GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        switch (rotNum % 4)
        {
            case 0:
                rigid.velocity = Vector3.up * 3;
                break;
            case 1:
                rigid.velocity = Vector3.right * 3;
                break;
            case 2:
                rigid.velocity = Vector3.down * 3;
                break;
            case 3:
                rigid.velocity = Vector3.left * 3;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        drawnGauge -= 300 * Time.deltaTime;
        drawnText.text = ((int)drawnGauge).ToString();
        if (drawnGauge <= 0)
        {
            drawnGauge = 1;
            isGameOver = true;
            Debug.Log("Game Over");
            //SceneManager.LoadScene("ending");
        }

        int a = (int)drawnGauge / 200;
        switch (a)
        {
            case 5:
            case 4:
                sr.material.color = new Color(1f, 1f, 1f);
                break;
            case 3:
                sr.material.color = new Color(0.6f, 0.6f, 1f);
                break;
            case 2:
                sr.material.color = new Color(0.4f, 0.4f, 1f);
                break;
            case 1:
                sr.material.color = new Color(0.2f, 0.2f, 1f);
                break;
            case 0:
                sr.material.color = new Color(0f, 0f, 1f);
                break;

        }
        if (Input.GetMouseButtonDown(0))
        {
            x1 = Input.mousePosition.x;
        }

        if (Input.GetMouseButtonUp(0))
        {
            x2 = Input.mousePosition.x;

            if (x1 > x2)
                if (x1 - x2 > 50)
                    rotNum--;
            if (x1 < x2)
                if (x2 - x1 > 50)
                    rotNum++;
            if (rotNum == 0)
                rotNum = 4;
            Debug.Log(rotNum);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ColEvent")
        {
            lifes[colNum].SetActive(false);
            colNum++;

            if (colNum == lifes.Length)
            {
                isGameOver = true;
                Debug.Log("Game Over");
                //SceneManager.LoadScene("ending");
            }
        }

        else if (collision.gameObject.tag == "Goal")
        {
            Debug.Log("Stage Success");
            //SceneManager.LoadScene("ending");
        }

        else if (collision.gameObject.tag == "Fail")
        {
            isGameOver = true;
            Debug.Log("Game Over");
            //SceneManager.LoadScene("ending");
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "FloatingObst" && drawnGauge > 800)
        {
            lifes[colNum].SetActive(false);
            colNum++;

            if (colNum == lifes.Length)
            {
                isGameOver = true;
                Debug.Log("Game Over");
                //SceneManager.LoadScene("ending");
            }
        }

        else if (c.gameObject.tag == "Life")
        {
            if (colNum != 0)
            {
                colNum--;
                lifes[colNum].SetActive(true);
                c.gameObject.SetActive(false);
            }

        }
    }

    public void SwimButtonEvent()
    {
        if (drawnGauge <= 1000)
            drawnGauge += 70;
    }
}