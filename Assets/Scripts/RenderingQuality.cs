﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenderingQuality : MonoBehaviour
{
    /*
    This script toggles the rendering quality of the simulator between High Quality
    (i.e. HDRP and post-processing enabled), Medium Quality (i.e. only HDRP enabled)
    and Low Quality (i.e. HDRP and post-processing disabled). The rendering quality
    also affects the shadows being generated in real-time.
    */

    //public GameObject PostProcessVolume;
    public GameObject HQ_HDRPSettings;
    public GameObject UQ_HDRPSettings;
    public GameObject ReflectionProbe;
    public Light SceneLight;
    public Text Label;

    private int Mode = 0;

    private void Start()
    {
        //PostProcessVolume.SetActive(false);
        HQ_HDRPSettings.SetActive(false);
        UQ_HDRPSettings.SetActive(false);
        ReflectionProbe.SetActive(false);
        SceneLight.shadows = LightShadows.None;
        Label.text = "Low Quality";
    }

    public void ToggleRenderingQuality()
    {
        Mode += 1;
        if(Mode > 2)
        {
            Mode = 0;
        }
        if(Mode == 0)
        {
            //PostProcessVolume.SetActive(false);
            HQ_HDRPSettings.SetActive(false);
            UQ_HDRPSettings.SetActive(false);
            ReflectionProbe.SetActive(false);
            SceneLight.shadows = LightShadows.None;
            Label.text = "Low Quality";
        }
        else if(Mode == 1)
        {
            //PostProcessVolume.SetActive(false);
            HQ_HDRPSettings.SetActive(true);
            UQ_HDRPSettings.SetActive(false);
            ReflectionProbe.SetActive(false);
            SceneLight.shadows = LightShadows.Hard;
            Label.text = "High Quality";
        }
        else
        {
            //PostProcessVolume.SetActive(true);
            HQ_HDRPSettings.SetActive(false);
            UQ_HDRPSettings.SetActive(true);
            ReflectionProbe.SetActive(true);
            SceneLight.shadows = LightShadows.Soft;
            Label.text = "Ultra Quality";
        }
    }
}
