﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ClickAnimals : MonoBehaviour
{
    public static ClickAnimals Animals;
    public int selection, lifeStage;

    private void Awake()
    {
        Animals = this;
        selection=0;
        lifeStage=0;

    }
    
    public GameObject BigRabbit;
    public GameObject BigCat;
    public GameObject BigDuck;

    public Button RabbitButton;
    public Button CatButton;
    public Button DuckButton;
    public static int SelectedAnimal = -1;

    // Start is called before the first frame update
    void Start()
    {
        BigRabbit.SetActive(false);
        BigCat.SetActive(false);
        BigDuck.SetActive(false);

        RabbitButton.onClick.AddListener(ShowBigRabbit);
        CatButton.onClick.AddListener(ShowBigCat);
        DuckButton.onClick.AddListener(ShowBigDuck);
    }

    void ShowBigRabbit()
    {
        BigRabbit.SetActive(false);
        BigCat.SetActive(false);
        BigDuck.SetActive(false);
        BigRabbit.SetActive(true);
        SelectedAnimal = 0;
        
    }
    void ShowBigCat()
    {
        BigRabbit.SetActive(false);
        BigCat.SetActive(false);
        BigDuck.SetActive(false);
        BigCat.SetActive(true);
        SelectedAnimal = 1;

    }
    void ShowBigDuck()
    {
        BigRabbit.SetActive(false);
        BigCat.SetActive(false);
        BigDuck.SetActive(false);
        BigDuck.SetActive(true);
        SelectedAnimal = 2;

    }

    public void clickRabbit(){
        Animals.selection=0;
        Animals.lifeStage=0;
    }

    public void clickCat(){
        Animals.selection=1;
        Animals.lifeStage=0;
    }

    public void clickBird(){
        Animals.selection=2;
        Animals.lifeStage=0;
    }

    public class Change : MonoBehaviour {
        public void SceneChange() {
            SceneManager.LoadScene("HomeScene");

        }
        
    }


    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
