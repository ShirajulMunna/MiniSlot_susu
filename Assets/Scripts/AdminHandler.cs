using JGM.Game.Rollers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminHandler : MonoBehaviour
{
    public Slider[] adminSliders;
    private int rotationSpeed, rotationTime, gift, particles;

    void Start()
    {
        // Admin
        rotationSpeed = PlayerPrefs.GetInt("rotationSpeed");
        rotationTime = PlayerPrefs.GetInt("rotationTime");
        gift = PlayerPrefs.GetInt("gift");
        particles = PlayerPrefs.GetInt("particles");
        
        UpdateSpeedSlider();
        UpdateTimeSlider();
        UpdateGiftSlider();
        UpdateParticlesSlider();

        //End Admin

    }


    #region
    public void UpdateSpeedSlider()
    {
        if (rotationSpeed == 1000)
        {
            adminSliders[0].value = 1;

        }
        else if (rotationSpeed == 2000)
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
        if (rotationTime == 5)
        {
            adminSliders[1].value = 1;

        }
        else if (rotationTime == 7)
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
