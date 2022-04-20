using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class BankLoadTest : MonoBehaviour
{
    public void LoadBank(string bank)
    {
        RuntimeManager.LoadBank(bank);
    }

    public void CheckMasterBank()
    {
        if (RuntimeManager.HasBankLoaded("Master"))
            Debug.Log("Master bank has loaded");
        else
            Debug.Log("Master bank has not loaded");
    }

    public void CheckCoolBank()
    {
        if (RuntimeManager.HasBankLoaded("CoolBank"))
            Debug.Log("CoolBank bank has loaded");
        else
            Debug.Log("CoolBank bank has not loaded");
    }
}
