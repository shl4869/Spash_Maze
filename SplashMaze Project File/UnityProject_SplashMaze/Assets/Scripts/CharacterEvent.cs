using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterEvent : MonoBehaviour
{
    public static bool isGameOver = false;
    public static bool isLifeItem;

    public GameObject[] MapLevel;
    public GameObject[] lifes;
    public GameObject characterObj;
    public GameObject tubeIcon;
    public Text drawnText;
    public Rigidbody2D rigid;
    public SpriteRenderer sr;
    public AudioSource SoundClip;
    [SerializeField] public AudioClip[] clip;
    Animator anim;

    public int colNum;
    public int rotNum;
    public int mapNum = 0;
    public float x1, x2;
    
    public float drawnGauge;
    public float charNum;
    public bool isTube;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        SoundClip = GetComponent<AudioSource>();
        PlayBg(0);
        isLifeItem=false;

        colNum = 0;
        rotNum = 1;
        drawnGauge = 1000;
        //성장도에 따라 변수 0,1,2 적용(static 변수 이용)
        mapNum=ClickAnimals.Animals.lifeStage;

        rigid = characterObj.GetComponent<Rigidbody2D>();
        sr = characterObj.GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        MapLevel[0].SetActive(false);
        MapLevel[1].SetActive(false);
        MapLevel[2].SetActive(false);
        MapLevel[mapNum].SetActive(true);

        //캐릭터에 따라 변수값 조정 필요(static 변수 이용)
        anim.SetInteger("Character",ClickAnimals.Animals.selection);
        anim.SetBool("isBubble",true);
        isTube = false;
    }

    void FixedUpdate()
    {
        switch (rotNum % 4)
        {
            case 0:
                rigid.velocity = Vector3.up*5;
                break;
            case 1:
                rigid.velocity = Vector3.right*5;
                break;
            case 2:
                rigid.velocity = Vector3.down*5;
                break;
            case 3:
                rigid.velocity = Vector3.left*5;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("LifeItem: "+isLifeItem);
        if(isTube==false)
        {
            drawnGauge -= 300*Time.deltaTime;
        }

        else
        {
            drawnGauge=2000;
        }

        drawnText.text = ((int)drawnGauge).ToString();

        if (drawnGauge <= 0)
        {
            drawnGauge = 1;
            isGameOver = true;
            Debug.Log("Game Over");
            SceneManager.LoadScene("5_FailScene");
        }

        int a = (int) drawnGauge / 200;
        switch (a)
        {
            case 10:
                sr.material.color = new Color(1f, 1f, 0f);
                break;
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

         if (Input.GetMouseButtonDown(0)&&Input.mousePosition.y>400&&Input.mousePosition.x>50)
        {
            x1 = Input.mousePosition.x;
        }

        if(Input.GetMouseButtonUp(0)&&Input.mousePosition.y>400&&Input.mousePosition.x<1030)
        {
            x2 = Input.mousePosition.x;

            if (x1 > x2)
                if (x1 - x2 > 100)
                    rotNum--;
            if (x1 < x2)
                 if (x2 - x1 > 100)
                    rotNum++;
            if(rotNum==0)
                rotNum = 4;
        }
       switch (rotNum % 4)
        {
            case 0:
                anim.SetInteger("rotNum",4);
                break;
            case 1:
                anim.SetInteger("rotNum",1);
                break;
            case 2:
                anim.SetInteger("rotNum",2);
                break;
            case 3:
                anim.SetInteger("rotNum",3);
                break;
        }
    } 
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(isTube==false)
        {
            if(collision.gameObject.tag == "ColEvent")
            {
                if(colNum != lifes.Length)
                    lifes[colNum].SetActive(false);
                colNum++;

                if (colNum == lifes.Length+1)
                {
                    isGameOver = true;
                    Debug.Log("Game Over");
                    SceneManager.LoadScene("5_FailScene");
                }
                else if(colNum == lifes.Length)
                    anim.SetBool("isBubble",false);
            }


        }
        
        if (collision.gameObject.tag == "Goal")
        {
            Debug.Log("Stage Success");
            isGameOver=false;
            ClickAnimals.Animals.lifeStage++;
            SceneManager.LoadScene("4_ClearScene");
            
        }

        else if (collision.gameObject.tag == "Fail")
        {
            isGameOver = true;
            Debug.Log("Game Over");
            SceneManager.LoadScene("5_FailScene");
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if(isTube==false){
            if(c.gameObject.tag == "FloatingObst" && drawnGauge > 800)
            {
                if(colNum != lifes.Length)
                    lifes[colNum].SetActive(false);
                colNum++;

                if (colNum == lifes.Length+1)
                {
                    isGameOver = true;
                    Debug.Log("Game Over");
                    SceneManager.LoadScene("5_FailScene");
                }
            
                else if(colNum == lifes.Length)
                    anim.SetBool("isBubble",false);
            }
        }

        if (c.gameObject.tag == "Life")
        {
            if(colNum == lifes.Length)
                anim.SetBool("isBubble",true);

            if (colNum != 0)
            {
                isLifeItem=true;
                colNum--;
                lifes[colNum].SetActive(true);
                c.gameObject.SetActive(false);
            }   
        }

        else if (c.gameObject.tag == "Tube")
        {
          isTube=true;
          PlayBg(1);
          sr.material.color = new Color(1f, 1f, 0f);
          c.gameObject.SetActive(false);
          tubeIcon.SetActive(true);
          Invoke("offTube",10);
        }
    }

    public void SwimButtonEvent()
    {
        if(drawnGauge<=1000)
            drawnGauge += 100;
    }

    void offTube(){
        isTube=false;
        tubeIcon.SetActive(false);
        sr.material.color = new Color(1f, 1f, 1f);
        drawnGauge=1000;
        PlayBg(0);
    }

    public void PlayBg(int num)
    {
        SoundClip.clip = clip[num];
        SoundClip.Play();
        SoundClip.loop = true;
    }
}
