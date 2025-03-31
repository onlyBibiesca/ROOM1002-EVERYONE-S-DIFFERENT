using UnityEngine;
using UnityEngine.UI;

public class TimerScript: MonoBehaviour
{
    [Header("Slider and Points Configuration")]
    public Slider timeSlider;         // The slider representing the time of day
    public int pointsPerSection = 4;  // Points needed to move to the next section (sunrise, morning, etc.)
    private int currentPoints = 0;    // Points accumulated in the current section
    private int currentSection = 0;   // The current section of the day (0 to 4)

    private const int totalSections = 5; // Total number of day sections (sunrise, morning, afternoon, evening, night)

    void Start()
    {
        // Initialize the arrow position on start
        UpdateArrowPosition();
    }

    /// <summary>
    /// Adds points from an action and updates the slider position.
    /// This method should be called when an action is performed.
    /// </summary>
    // <param name="points">The number of points the action takes</param>
    public void AddPoints(int points)
    {
        // Accumulate points from the action
        currentPoints += points;

        // Check if points exceed the section threshold
        while (currentPoints >= pointsPerSection)
        {
            // Subtract points for the completed section
            currentPoints -= pointsPerSection;

            // Move to the next section (looping back after the last section)
            currentSection = (currentSection + 1) % totalSections;
        }

        // Update the arrow slider position
        UpdateArrowPosition();
    }

    /// <summary>
    /// Updates the arrow slider position based on the current section and points.
    /// </summary>
    public void UpdateArrowPosition()
    {   

        // Calculate the width of each section on the slider (between 0 and 1)
        float sectionWidth = 1.0f / totalSections;

        // Calculate the slider's value based on the current section and progress within the section
        float position = (currentSection + (float)currentPoints / pointsPerSection) * sectionWidth;

        /*
        if (currentPoints % 2 == 0)
        {
            timeSlider.value += .25f;
        }

        else
        {
            timeSlider.value += .125f;
        }
        */

        /* for (int i = 0; i < totalSections; i++)
         {
             if (currentPoints == 2)
             {
                 timeSlider.value = .25f;

             }

             else if (currentPoints == 4)
             {
                 timeSlider.value = .50f;
             }
         }
         */

        // Update the slider value to move the arrow
        timeSlider.value = position;
    }
}