﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetsDisplay : MonoBehaviour
{
    private int planetNumber = 0;
    public GameObject[] planetScenes;
    private GameObject currentActivePlanet;
    public GameObject solarSystem;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < planetScenes.Length; i++)
        {
            planetScenes[i].SetActive(false);
        }

        /*for (int i = 0; i < planetImages.Length; i++)
        {
            planetImages[i].SetActive(false);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void next()
    {

        planetScenes[planetNumber].SetActive(false);

        planetNumber++;

        if (planetNumber == 8)
        {
            planetNumber = 0;

        }
        /*if (planetNumber != 0)
        {
            UIPanel.SetActive(true);
        }
        else
        {
            UIPanel.SetActive(false);
        }*/
        planetScenes[planetNumber].SetActive(true);
        //toggleImage(planetNumber);



        //apimanager.requestPlanetInformation(planetNumber);

    }
    public void previous()
    {

        planetScenes[planetNumber].SetActive(false);
        planetNumber--;
        if (planetNumber == -1)
        {
            planetNumber = 7;
        }
        /*if (planetNumber != 0)
        {
            UIPanel.SetActive(true);
        }
        else
        {
            UIPanel.SetActive(false);
        }*/
        planetScenes[planetNumber].SetActive(true);
        /*toggleImageBackwards(planetNumber);
        apimanager.requestPlanetInformation(planetNumber);*/
    }
    public void changeToCorrectPlanet(int index) {
        if (currentActivePlanet == null)
        {
            solarSystem.SetActive(false);
            planetScenes[index].SetActive(true);
            currentActivePlanet = planetScenes[index];
        }
        else
        {
            currentActivePlanet.SetActive(false);
            planetScenes[index].SetActive(true);
            currentActivePlanet = planetScenes[index];
        }
    }

    public void showSolarSystem() {
        if (currentActivePlanet != null) {
            currentActivePlanet.SetActive(false);
        }
        solarSystem.SetActive(true);
        currentActivePlanet = null;
    }

}
