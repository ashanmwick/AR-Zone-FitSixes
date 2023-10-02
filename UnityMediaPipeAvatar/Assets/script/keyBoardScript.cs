using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string subfolderName = "Screenshots";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            DateTime currentTime = DateTime.UtcNow;
            string timestamp = currentTime.ToString("yyyyMMddHHmmss");
            string screenshotFileName = timestamp + ".png";


            string subfolderPath = Application.dataPath + "/" + subfolderName;

            // Create the subfolder if it doesn't exist
            if (!Directory.Exists(subfolderPath))
            {
                Directory.CreateDirectory(subfolderPath);
            }

            // Define the file path within the subfolder
            string filePath = Path.Combine(subfolderPath, screenshotFileName);

            // Capture a screenshot and save it to the subfolder
            ScreenCapture.CaptureScreenshot(filePath);
        }

        
    }
}
