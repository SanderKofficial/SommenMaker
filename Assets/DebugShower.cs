// Test
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class DebugShower : MonoBehaviour
{
    public int maxLines = 4;
    private Queue<string> queue = new Queue<string>();
    private string currentText = "DEBUG";

    void OnEnable()
    {
        Application.logMessageReceivedThreaded += HandleLog;
    }

    void OnDisable()
    {
        Application.logMessageReceivedThreaded -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        // Verwijderd Oude berichten
        if (queue.Count >= maxLines) queue.Dequeue();

        queue.Enqueue(logString);

        var builder = new StringBuilder();
        foreach (string st in queue)
        {
            builder.Append(st).Append("\n");
        }

        currentText = builder.ToString();
    }

    void OnGUI()
    {
        GUI.Label(
           new Rect(
               5,                   // x, left offset
               Screen.height - 155, // y, bottom offset
               300f,                // width
               150f                 // height
           ),
           currentText,             // the display text
           GUI.skin.textArea        // use a multi-line text area
        );
    }
}

