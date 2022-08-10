using UnityEngine;

public class WaitForRightMouseDown : CustomYieldInstruction
{
    public override bool keepWaiting
    {
        get
        {
            // return bool suspends waiting or keeps waiting
            return !Input.GetMouseButtonDown(1);
        }
    }

    // Custom Constructor here
    public  WaitForRightMouseDown()
    {
        Debug.Log("Wait for Right Mouse Button Clicked Custom Yield Constructor!");
    }
}
