using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Date
{
    private DateTime dateInput;
    private DateTime today = DateTime.UtcNow.Date;

    public Date(DateTime dateInput)
    {
        this.dateInput = dateInput;
    }

    public string DateIsPastPresentOrFuture()
    {
        int result = DateTime.Compare(dateInput, today);
        string stringResult = string.Empty;
        if (result < 0)
        {
            stringResult = "La fecha ingresada es del PASADO.";
        }
        else if (result == 0)
        {
            stringResult = "La fecha ingresada es del PRESENTE.";
        }
        else if (result > 0)
        {
            stringResult = "La fecha ingresada es del FUTURO.";
        }

        return stringResult;
    }
}
