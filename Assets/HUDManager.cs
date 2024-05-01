using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HUDManager : MonoBehaviour
{
    public Text packagesDeliveredText;
    private int packagesDeliveredCount = 0;

    void UpdatePackagesDelivered()
    {
        packagesDeliveredText.text = "Packages Delivered: " + packagesDeliveredCount;
    }

    public void DeliverPackage()
    {
        packagesDeliveredCount++;
        UpdatePackagesDelivered();
    }
}
