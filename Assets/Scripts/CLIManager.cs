using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CLIManager : MonoBehaviour
{
    /*
	This script parses standard/custom command line arguments for AutoDRIVE Simulator
    and sets the simulation parameters accordingly.
	*/

    public GameObject Socket;
    public GameObject SocketIO;

    public InputField IP;
    public InputField Port;

    // Set parameters based on command line arguments
    void Awake()
    {
        string[] args = System.Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].ToLower() == "-ip")
            {
                IP.text = args[i + 1];
            }
            if (args[i].ToLower() == "-port")
            {
                Port.text = args[i + 1];
            }
        }
    }

    void Start()
    {
        if (Application.isBatchMode)
        {
            Socket.SetActive(true);
            SocketIO.SetActive(true);
        }
    }
}