using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Unity;
using Articy.Unity.Interfaces;
using UnityEngine.UI;

public class BranchChoice : MonoBehaviour
{
    private Branch branch;
    private ArticyFlowPlayer flowPlayer;
    [SerializeField]
    Text buttonText;
    public void AssignBranch(ArticyFlowPlayer aFlowPlayer, Branch aBranch)
    {
        branch = aBranch;
        flowPlayer = aFlowPlayer;
        IFlowObject target = aBranch.Target;
        buttonText.text = string.Empty;

        // For Menu Text (the short explanation of the actual response that the player chooses before the actual response is shown or heard)
        var objectWithMenuText = target as IObjectWithMenuText;
        if (objectWithMenuText != null)
        {
            buttonText.text = objectWithMenuText.MenuText;
        }

        if (string.IsNullOrEmpty(buttonText.text))
        {
            var objectWithText = target as IObjectWithText;
            if (objectWithText != null)
            {
                buttonText.text = objectWithText.Text;
            }
            else buttonText.text = ">>>";
        }
    }

    public void OnBranchSelected()
    {
        flowPlayer.Play(branch);
    }
}