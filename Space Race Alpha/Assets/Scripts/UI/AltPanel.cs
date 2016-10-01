﻿using UnityEngine;
using System.Collections;
using CodeControl;
using System;
using UnityEngine.UI;

public class AltPanel : MonoBehaviour {

    CraftModel model;

    public Text textPref;
    internal Text infoText;

	// Use this for initialization
	void Awake () {
        //Add listener
        Message.AddListener<InfoPanelMessage>(OnInfoPanelMessage);

        //instantiate text
        infoText = Instantiate(textPref, transform) as Text;

    }

    private void OnInfoPanelMessage(InfoPanelMessage m)
    {
        model = m.model as CraftModel;
    }

    // Update is called once per frame
    void Update () {

        if (model != null)
        {
            infoText.text = model.orbitalInfo.Alt.ToString("0") + " m| " + model.flightInfo.AltChangeSpeed.ToString("0.00") + " m/s";
        }
	
	}
}
