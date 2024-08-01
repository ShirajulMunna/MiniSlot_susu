using JGM.Game.Rollers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminHandler : MonoBehaviour
{
    public static AdminHandler Instance;
    public Slider[] adminSliders;
    private int rotationSpeed, rotationTime, gift, particles;

    void Start()
    {
        Instance = this;

        if (GameManager.Instance.quitValue == 50)
        {
            adminSliders[0].value = 1;
            adminSliders[1].value = 1;
            adminSliders[2].value = 1;
            adminSliders[3].value = 1;

        }
        else 
        {
            rotationSpeed = PlayerPrefs.GetInt("rotationSpeed", 500);
            rotationTime = PlayerPrefs.GetInt("rotationTime", 6);
            gift = PlayerPrefs.GetInt("gift", 3);
            particles = PlayerPrefs.GetInt("particles", 1);

            UpdateSpeedSlider();
            UpdateTimeSlider();
            UpdateGiftSlider();
            UpdateParticlesSlider();


        }




        GameManager.Instance.sliderValue[0] = PlayerPrefs.GetFloat("NoMatch", 99);
        GameManager.Instance.sliderValue[1] = PlayerPrefs.GetFloat("Watch", 0);
        GameManager.Instance.sliderValue[2] = PlayerPrefs.GetFloat("Camera",0);
        GameManager.Instance.sliderValue[3] = PlayerPrefs.GetFloat("Laptop", 0);
        GameManager.Instance.sliderValue[4] = PlayerPrefs.GetFloat("Bag", 0);
        GameManager.Instance.sliderValue[5] = PlayerPrefs.GetFloat("Mobile", 0);

       




    }


    #region
    public void UpdateSpeedSlider()
    {
        if (rotationSpeed == 500)
        {
            adminSliders[0].value = 1;

        }
        else if (rotationSpeed == 550)
        {
            adminSliders[0].value = 2;

        }
        else
        {
            adminSliders[0].value = 3;


        }

    }
    public void UpdateTimeSlider()
    {
        if (rotationTime == 6)
        {
            adminSliders[1].value = 1;

        }
        else if (rotationTime == 8)
        {
            adminSliders[1].value = 2;

        }
        else
        {
            adminSliders[1].value = 3;

        }

    }
    public void UpdateGiftSlider()
    {
        if (gift == 3)
        {
            adminSliders[2].value = 1;

        }
        else if (gift == 4)
        {
            adminSliders[2].value = 2;

        }
        else
        {
            adminSliders[2].value = 3;

        }
        RollerManager.Instance.ItemChange(gift-2);
        GameManager.Instance.itemCount = gift;

    }
    public void UpdateParticlesSlider()
    {
        if (particles == 1)
        {
            adminSliders[3].value = 1;

        }
        else if (particles == 2)
        {
            adminSliders[3].value = 2;

        }


    }
    #endregion

    
}
