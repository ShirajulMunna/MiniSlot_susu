using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParcentageHandler : MonoBehaviour
{
   
    public Slider[] parcentageSliders;
    private float noMatch, watch, cameraGift, laptop, bag, mobile;

    void Start()
    {
      

        //Parcentages
        noMatch = PlayerPrefs.GetFloat("NoMatch");
        watch = PlayerPrefs.GetFloat("Watch");
        cameraGift = PlayerPrefs.GetFloat("Camera");
        laptop = PlayerPrefs.GetFloat("Laptop");
        bag = PlayerPrefs.GetFloat("Bag");
        mobile = PlayerPrefs.GetFloat("Mobile");


        UpdateNoMatchSlider();
        UpdateClockSlider();
        UpdateCameraSlider();
        UpdateLaptopSlider();
        UpdateBagSlider();
        UpdateMobileSlider();

        //End parcentages

        
    }

    public void UpdateNoMatchSlider() 
    {
        parcentageSliders[0].value = noMatch;
    
    }
    public void UpdateClockSlider()
    {
        parcentageSliders[1].value = watch;

    }
    public void UpdateCameraSlider()
    {
        parcentageSliders[2].value = cameraGift;

    }
    public void UpdateLaptopSlider()
    {
        parcentageSliders[3].value = laptop;

    }
    public void UpdateBagSlider()
    {
        parcentageSliders[4].value = bag;

    }
    public void UpdateMobileSlider()
    {
        parcentageSliders[5].value = mobile;

    }
   


}
