using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterView : MonoBehaviour
{
    

    public GameObject BabyRabbit; // 0 0  
    public GameObject BabyCat; // 1 0
    public GameObject BabyBird; // 2 0
    public GameObject TeenRabbit; // 0 1
    public GameObject TeenCat; // 1 1
    public GameObject TeenBird; // 2 1
    public GameObject AdultRabbit; // 0 2
    public GameObject AdultCat; // 1 2
    public GameObject AdultBird; // 2 2

    public int selection;
    public int lifeStage; // 0 -> 응애, 1 -> 청소년, 2 -> 어른

    void Awake(){
        selection=ClickAnimals.Animals.selection;
        lifeStage=ClickAnimals.Animals.lifeStage;
    }

    void Start()
    {

        BabyRabbit.SetActive(false);
        TeenRabbit.SetActive(false);
        AdultRabbit.SetActive(false);
        BabyCat.SetActive(false);
        TeenCat.SetActive(false);
        AdultCat.SetActive(false);
        BabyBird.SetActive(false);
        TeenBird.SetActive(false);
        AdultBird.SetActive(false);


        if ((selection == 0) && (lifeStage == 0)) // 응애 토끼
        {
            BabyRabbit.SetActive(true);
            TeenRabbit.SetActive(false);
            AdultRabbit.SetActive(false);
            BabyCat.SetActive(false);
            TeenCat.SetActive(false);
            AdultCat.SetActive(false);
            BabyBird.SetActive(false);
            TeenBird.SetActive(false);
            AdultBird.SetActive(false);
        }

        else if ((selection == 0) && (lifeStage == 1)) // 청소년 토끼
        {
            BabyRabbit.SetActive(false);
            TeenRabbit.SetActive(true);
            AdultRabbit.SetActive(false);
            BabyCat.SetActive(false);
            TeenCat.SetActive(false);
            AdultCat.SetActive(false);
            BabyBird.SetActive(false);
            TeenBird.SetActive(false);
            AdultBird.SetActive(false);
        }

        else if ((selection == 0) && (lifeStage == 2)) // 어른 토끼
        {
            BabyRabbit.SetActive(false);
            TeenRabbit.SetActive(false);
            AdultRabbit.SetActive(true);
            BabyCat.SetActive(false);
            TeenCat.SetActive(false);
            AdultCat.SetActive(false);
            BabyBird.SetActive(false);
            TeenBird.SetActive(false);
            AdultBird.SetActive(false);
        }

        else if ((selection == 1) && (lifeStage == 0)) // 응애 고양이
        {
            BabyRabbit.SetActive(false);
            TeenRabbit.SetActive(false);
            AdultRabbit.SetActive(false);
            BabyCat.SetActive(true);
            TeenCat.SetActive(false);
            AdultCat.SetActive(false);
            BabyBird.SetActive(false);
            TeenBird.SetActive(false);
            AdultBird.SetActive(false);
        }

        else if ((selection == 1) && (lifeStage == 1)) // 청소년 고양이
        {
            BabyRabbit.SetActive(false);
            TeenRabbit.SetActive(false);
            AdultRabbit.SetActive(false);
            BabyCat.SetActive(false);
            TeenCat.SetActive(true);
            AdultCat.SetActive(false);
            BabyBird.SetActive(false);
            TeenBird.SetActive(false);
            AdultBird.SetActive(false);
        }

        else if ((selection == 1) && (lifeStage == 2)) // 어른 고양이
        {
            BabyRabbit.SetActive(false);
            TeenRabbit.SetActive(false);
            AdultRabbit.SetActive(false);
            BabyCat.SetActive(false);
            TeenCat.SetActive(false);
            AdultCat.SetActive(true);
            BabyBird.SetActive(false);
            TeenBird.SetActive(false);
            AdultBird.SetActive(false);
        }

        else if ((selection == 2) && (lifeStage == 0)) // 응애 오리
        {
            BabyRabbit.SetActive(false);
            TeenRabbit.SetActive(false);
            AdultRabbit.SetActive(false);
            BabyCat.SetActive(false);
            TeenCat.SetActive(false);
            AdultCat.SetActive(false);
            BabyBird.SetActive(true);
            TeenBird.SetActive(false);
            AdultBird.SetActive(false);
        }

        else if ((selection == 2) && (lifeStage == 1)) // 청소년 오리
        {
            BabyRabbit.SetActive(false);
            TeenRabbit.SetActive(false);
            AdultRabbit.SetActive(false);
            BabyCat.SetActive(false);
            TeenCat.SetActive(false);
            AdultCat.SetActive(false);
            BabyBird.SetActive(false);
            TeenBird.SetActive(true);
            AdultBird.SetActive(false);
        }

        else if ((selection == 2) && (lifeStage == 2)) // 어른 오리
        {
            BabyRabbit.SetActive(false);
            TeenRabbit.SetActive(false);
            AdultRabbit.SetActive(false);
            BabyCat.SetActive(false);
            TeenCat.SetActive(false);
            AdultCat.SetActive(false);
            BabyBird.SetActive(false);
            TeenBird.SetActive(false);
            AdultBird.SetActive(true);
        }

    }

   
}
