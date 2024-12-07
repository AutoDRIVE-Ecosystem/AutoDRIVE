using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using LLMUnity;

public class TestAgentLLM : MonoBehaviour {

    // AI agent
    public LLMCharacter llmCharacter;
    public InputField playerText;
    public Text AIText;

    public string prompt;

    // Reference to the "Sun" object
    public TestAgentRBM sun;
    public float angle;

    void Start()
    {
        playerText.onSubmit.AddListener(onInputFieldSubmit);
        playerText.Select();
    }

    void onInputFieldSubmit(string message)
    {
        playerText.interactable = false;
        AIText.text = "...";
        // Debug.Log(ExtractTime(message));
        // string full_message = "Generally, what is the angle of sun in degrees at " + ExtractTime(message) + "? Give very brief answer!";
        prompt = message;
        string full_message = message + "Generally, what is the angle of sun in degrees at the given time?  Note that the sun rises at 0 degress, sets at 180 degrees, and it is night from 180 to 360 degrees. Give me only the final angle (don't even print units) in response!";
        _ = llmCharacter.Chat(full_message, HandleReply, ReplyCompleted);
    }

    void HandleReply(string reply){
        // do something with the reply from the model
        // Debug.Log(reply);
        // AIText.text = reply;
        if(float.TryParse(reply, out angle))
        {
            Debug.Log(reply);
        }
        else
        {
            /// Something wrong. `reply` has incorrect float value (possibly other string part as well)
            angle = sun.currentAngle;
            AIText.text = "Sorry, I didn't quite get that!";
        }
    }

    void HandleReplyUI(string reply){
        // do something with the reply from the model
        // Debug.Log(reply);
        AIText.text = reply;
    }

    void ReplyCompleted(){
        // do something when the reply from the model is complete
        // Debug.Log("The AI replied");
        string full_message = prompt + "Say that the angle of sun in degrees at the given time is " + angle + "Answer in one short sentence.";
        _ = llmCharacter.Chat(full_message, HandleReplyUI);
        sun.targetAngle = angle;
        playerText.interactable = true;
        playerText.Select();
        playerText.text = "";
    }

    public void CancelRequests()
    {
        llmCharacter.CancelRequests();
        ReplyCompleted();
    }

    public void ExitGame()
    {
        Debug.Log("Exit button clicked");
        Application.Quit();
    }

    bool onValidateWarning = true;
    void OnValidate()
    {
        if (onValidateWarning && !llmCharacter.remote && llmCharacter.llm != null && llmCharacter.llm.model == "")
        {
            Debug.LogWarning($"Please select a model in the {llmCharacter.llm.gameObject.name} GameObject!");
            onValidateWarning = false;
        }
    }

    // Function to extract and convert angle
    public static string ExtractAngle(string input)
    {
        // Pattern to match angles in various formats (e.g., "45", "90 degrees", "180°")
        string pattern = @"^(-?\d+(\.\d+)?)\s*(°|degrees?)?$";
        
        var match = Regex.Match(input.Trim(), pattern, RegexOptions.IgnoreCase);
        
        if (match.Success)
        {
            // Extract the numeric value of the angle
            string angleString = match.Groups[1].Value;
            Debug.Log(angleString);
            return angleString;
        }
        else
        {
            return "Invalid angle format";
        }
    }

    // Function to extract and convert time to 24-hour format
    public static string ExtractTime(string input)
    {
        // First check if input is already in 24-hour format (e.g., "16:00")
        string pattern24Hour = @"^(\d{2}):(\d{2})$";
        var match24Hour = Regex.Match(input, pattern24Hour);

        if (match24Hour.Success)
        {
            // If the input is already in 24-hour format, just return it
            return input; // Already in the correct format
        }

        // If it's not a valid 24-hour format, process it as a 12-hour format with am/pm
        string pattern12Hour = @"(\d{1,2})(?::(\d{2}))?\s?(am|pm)";
        var match12Hour = Regex.Match(input.ToLower(), pattern12Hour);

        if (match12Hour.Success)
        {
            // Extract hours, minutes (if any), and period (AM/PM)
            int hours = int.Parse(match12Hour.Groups[1].Value);
            int minutes = match12Hour.Groups[2].Success ? int.Parse(match12Hour.Groups[2].Value) : 0;
            string period = match12Hour.Groups[3].Value;

            // Convert to 24-hour format
            if (period == "am")
            {
                if (hours == 12) // Special case for 12 AM (midnight)
                    hours = 0;
            }
            else if (period == "pm")
            {
                if (hours != 12) // Special case for 12 PM (noon)
                    hours += 12;
            }

            // Format time as HH:mm (24-hour format)
            return string.Format("{0:D2}:{1:D2}", hours, minutes);
        }
        else
        {
            return "Invalid time format";
        }
    }
}